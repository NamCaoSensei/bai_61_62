using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Microsoft.Data.SqlClient;
using bai6_2.DTO;

namespace bai6_2.DAL
{
    public class ChamCongDAL
    {
        private SqlDataAdapter? _adapter;
        private SqlCommandBuilder? _builder;
        private DataTable? _currentTable;

        /// <summary>
        /// Mô hình ngắt kết nối (Disconnected Model):
        /// Nạp toàn bộ nhân viên vào DataTable chấm công theo Tháng/Năm bằng SqlDataAdapter
        /// </summary>
        public DataTable LoadBangChamCong(string thangNam)
        {
            if (!DbHelper.CheckDatabaseConnection())
            {
                return MockLoadBangChamCong(thangNam);
            }

            var conn = DbHelper.GetConnection();
            conn.Open();

            // Đảm bảo các nhân viên chưa có bản ghi trong tháng sẽ được tự động tạo bản ghi mặc định
            string ensureSql = @"
                INSERT INTO BangChamCong (MaNV, ThangNam, SoNgayCong, SoGioOT, TrangThai)
                SELECT nv.MaNV, @ThangNam, 22.0, 0.0, N'Chưa chốt'
                FROM NhanVien nv
                WHERE NOT EXISTS (
                    SELECT 1 FROM BangChamCong cc 
                    WHERE cc.MaNV = nv.MaNV AND cc.ThangNam = @ThangNam
                )";
            using (var cmdEnsure = new SqlCommand(ensureSql, conn))
            {
                cmdEnsure.Parameters.Add(new SqlParameter("@ThangNam", SqlDbType.VarChar, 7) { Value = thangNam });
                cmdEnsure.ExecuteNonQuery();
            }

            // Truy vấn lấy dữ liệu chấm công ngắt kết nối
            string selectSql = @"
                SELECT cc.MaCong, cc.MaNV, nv.HoTen, pb.TenPB, cc.ThangNam, cc.SoNgayCong, cc.SoGioOT, cc.TrangThai
                FROM BangChamCong cc
                INNER JOIN NhanVien nv ON cc.MaNV = nv.MaNV
                INNER JOIN PhongBan pb ON nv.MaPB = pb.MaPB
                WHERE cc.ThangNam = @ThangNam
                ORDER BY cc.MaNV";

            _adapter = new SqlDataAdapter(selectSql, conn);
            _adapter.SelectCommand.Parameters.Add(new SqlParameter("@ThangNam", SqlDbType.VarChar, 7) { Value = thangNam });

            // Tự động sinh lệnh InsertCommand, UpdateCommand, DeleteCommand
            _builder = new SqlCommandBuilder(_adapter);

            _currentTable = new DataTable();
            _adapter.Fill(_currentTable);

            // Đặt khóa chính cho DataTable
            if (_currentTable.Columns.Contains("MaCong"))
            {
                _currentTable.PrimaryKey = new DataColumn[] { _currentTable.Columns["MaCong"]! };
            }

            return _currentTable;
        }

        /// <summary>
        /// Lưu chấm công ngắt kết nối về SQL Server trong 1 thao tác bằng adapter.Update()
        /// </summary>
        public (bool Success, string Message, int AffectedRows) SaveBangChamCong(DataTable dataTable)
        {
            if (dataTable == null) return (false, "Không có dữ liệu bảng chấm công!", 0);

            if (!DbHelper.CheckDatabaseConnection())
            {
                return MockSaveBangChamCong(dataTable);
            }

            try
            {
                if (_adapter == null)
                {
                    var conn = DbHelper.GetConnection();
                    _adapter = new SqlDataAdapter("SELECT MaCong, MaNV, ThangNam, SoNgayCong, SoGioOT, TrangThai FROM BangChamCong", conn);
                    _builder = new SqlCommandBuilder(_adapter);
                }

                // Cấu hình UpdateCommand chuyên biệt để đồng bộ SoNgayCong và SoGioOT
                int rows = _adapter.Update(dataTable);
                dataTable.AcceptChanges();
                return (true, $"Đồng bộ thành công {rows} bản ghi chấm công về CSDL SQL Server!", rows);
            }
            catch (Exception ex)
            {
                return (false, $"Lỗi đồng bộ SqlDataAdapter: {ex.Message}", 0);
            }
        }

        private DataTable MockLoadBangChamCong(string thangNam)
        {
            var dt = new DataTable("BangChamCong");
            dt.Columns.Add("MaCong", typeof(int));
            dt.Columns.Add("MaNV", typeof(int));
            dt.Columns.Add("HoTen", typeof(string));
            dt.Columns.Add("TenPB", typeof(string));
            dt.Columns.Add("ThangNam", typeof(string));
            dt.Columns.Add("SoNgayCong", typeof(double));
            dt.Columns.Add("SoGioOT", typeof(double));
            dt.Columns.Add("TrangThai", typeof(string));
            dt.PrimaryKey = new DataColumn[] { dt.Columns["MaCong"]! };

            // Khởi tạo bản ghi nếu chưa có
            foreach (var nv in DbHelper.MockDb.NhanViens)
            {
                var exist = DbHelper.MockDb.BangChamCongs.FirstOrDefault(x => x.MaNV == nv.MaNV && x.ThangNam == thangNam);
                if (exist == null)
                {
                    int newMaCong = DbHelper.MockDb.BangChamCongs.Count > 0 ? DbHelper.MockDb.BangChamCongs.Max(x => x.MaCong) + 1 : 1;
                    exist = new BangChamCongDTO
                    {
                        MaCong = newMaCong,
                        MaNV = nv.MaNV,
                        HoTen = nv.HoTen,
                        TenPB = nv.TenPB,
                        ThangNam = thangNam,
                        SoNgayCong = 22.0,
                        SoGioOT = 0.0,
                        TrangThai = "Chưa chốt"
                    };
                    DbHelper.MockDb.BangChamCongs.Add(exist);
                }

                dt.Rows.Add(exist.MaCong, exist.MaNV, nv.HoTen, nv.TenPB, exist.ThangNam, exist.SoNgayCong, exist.SoGioOT, exist.TrangThai);
            }

            dt.AcceptChanges();
            _currentTable = dt;
            return dt;
        }

        private (bool Success, string Message, int AffectedRows) MockSaveBangChamCong(DataTable dataTable)
        {
            int updated = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                int maCong = Convert.ToInt32(row["MaCong"]);
                double soNgayCong = Convert.ToDouble(row["SoNgayCong"]);
                double soGioOT = Convert.ToDouble(row["SoGioOT"]);

                var exist = DbHelper.MockDb.BangChamCongs.FirstOrDefault(x => x.MaCong == maCong);
                if (exist != null)
                {
                    exist.SoNgayCong = soNgayCong;
                    exist.SoGioOT = soGioOT;
                    updated++;
                }
            }
            dataTable.AcceptChanges();
            return (true, $"[Disconnected Model]: Đã cập nhật {updated} bản ghi chấm công qua DataTable/DataAdapter!", updated);
        }
    }
}
