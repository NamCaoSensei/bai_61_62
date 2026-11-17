using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Microsoft.Data.SqlClient;
using bai6_2.DTO;

namespace bai6_2.DAL
{
    public class PhongBanDAL
    {
        public List<PhongBanDTO> GetAll()
        {
            if (!DbHelper.CheckDatabaseConnection())
            {
                return DbHelper.MockDb.PhongBans.Select(p => new PhongBanDTO
                {
                    MaPB = p.MaPB,
                    TenPB = p.TenPB,
                    MoTa = p.MoTa
                }).ToList();
            }

            var list = new List<PhongBanDTO>();
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT MaPB, TenPB, Mota FROM PhongBan ORDER BY MaPB";
                using var cmd = new SqlCommand(query, conn);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new PhongBanDTO
                    {
                        MaPB = Convert.ToInt32(reader["MaPB"]),
                        TenPB = reader["TenPB"].ToString() ?? "",
                        MoTa = reader["Mota"] == DBNull.Value ? "" : reader["Mota"].ToString() ?? ""
                    });
                }
            }
            return list;
        }
    }

    public class NhanVienDAL
    {
        public List<NhanVienDTO> GetAll()
        {
            if (!DbHelper.CheckDatabaseConnection())
            {
                return DbHelper.MockDb.NhanViens.Select(n => new NhanVienDTO
                {
                    MaNV = n.MaNV,
                    HoTen = n.HoTen,
                    NgaySinh = n.NgaySinh,
                    CCCD = n.CCCD,
                    MaPB = n.MaPB,
                    TenPB = n.TenPB,
                    LuongCoBan = n.LuongCoBan,
                    HeSoLuong = n.HeSoLuong
                }).ToList();
            }

            var list = new List<NhanVienDTO>();
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT nv.MaNV, nv.HoTen, nv.NgaySinh, nv.CCCD, nv.MaPB, pb.TenPB, nv.LuongCoBan, nv.HeSoLuong
                    FROM NhanVien nv
                    INNER JOIN PhongBan pb ON nv.MaPB = pb.MaPB
                    ORDER BY nv.MaNV";
                using var cmd = new SqlCommand(query, conn);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new NhanVienDTO
                    {
                        MaNV = Convert.ToInt32(reader["MaNV"]),
                        HoTen = reader["HoTen"].ToString() ?? "",
                        NgaySinh = reader["NgaySinh"] == DBNull.Value ? null : Convert.ToDateTime(reader["NgaySinh"]),
                        CCCD = reader["CCCD"].ToString() ?? "",
                        MaPB = Convert.ToInt32(reader["MaPB"]),
                        TenPB = reader["TenPB"].ToString() ?? "",
                        LuongCoBan = Convert.ToDecimal(reader["LuongCoBan"]),
                        HeSoLuong = Convert.ToDouble(reader["HeSoLuong"])
                    });
                }
            }
            return list;
        }

        /// <summary>
        /// Tìm kiếm nhân viên theo tên, phòng ban hoặc CCCD bằng Parameterized Query
        /// </summary>
        public List<NhanVienDTO> Search(string keyword, int? maPB = null)
        {
            if (!DbHelper.CheckDatabaseConnection())
            {
                var kw = (keyword ?? "").Trim();
                var query = DbHelper.MockDb.NhanViens.AsEnumerable();

                if (!string.IsNullOrWhiteSpace(kw))
                {
                    query = query.Where(n => n.HoTen.Contains(kw, StringComparison.OrdinalIgnoreCase) ||
                                             n.CCCD.Contains(kw, StringComparison.OrdinalIgnoreCase) ||
                                             n.TenPB.Contains(kw, StringComparison.OrdinalIgnoreCase));
                }

                if (maPB.HasValue && maPB.Value > 0)
                {
                    query = query.Where(n => n.MaPB == maPB.Value);
                }

                return query.Select(n => new NhanVienDTO
                {
                    MaNV = n.MaNV,
                    HoTen = n.HoTen,
                    NgaySinh = n.NgaySinh,
                    CCCD = n.CCCD,
                    MaPB = n.MaPB,
                    TenPB = n.TenPB,
                    LuongCoBan = n.LuongCoBan,
                    HeSoLuong = n.HeSoLuong
                }).ToList();
            }

            var list = new List<NhanVienDTO>();
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT nv.MaNV, nv.HoTen, nv.NgaySinh, nv.CCCD, nv.MaPB, pb.TenPB, nv.LuongCoBan, nv.HeSoLuong
                    FROM NhanVien nv
                    INNER JOIN PhongBan pb ON nv.MaPB = pb.MaPB
                    WHERE (nv.HoTen LIKE @Keyword OR nv.CCCD LIKE @Keyword OR pb.TenPB LIKE @Keyword)";

                if (maPB.HasValue && maPB.Value > 0)
                {
                    query += " AND nv.MaPB = @MaPB";
                }

                query += " ORDER BY nv.MaNV";

                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@Keyword", SqlDbType.NVarChar) { Value = $"%{keyword.Trim()}%" });
                if (maPB.HasValue && maPB.Value > 0)
                {
                    cmd.Parameters.Add(new SqlParameter("@MaPB", SqlDbType.Int) { Value = maPB.Value });
                }

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new NhanVienDTO
                    {
                        MaNV = Convert.ToInt32(reader["MaNV"]),
                        HoTen = reader["HoTen"].ToString() ?? "",
                        NgaySinh = reader["NgaySinh"] == DBNull.Value ? null : Convert.ToDateTime(reader["NgaySinh"]),
                        CCCD = reader["CCCD"].ToString() ?? "",
                        MaPB = Convert.ToInt32(reader["MaPB"]),
                        TenPB = reader["TenPB"].ToString() ?? "",
                        LuongCoBan = Convert.ToDecimal(reader["LuongCoBan"]),
                        HeSoLuong = Convert.ToDouble(reader["HeSoLuong"])
                    });
                }
            }
            return list;
        }

        public bool Insert(NhanVienDTO nv)
        {
            if (!DbHelper.CheckDatabaseConnection())
            {
                if (DbHelper.MockDb.NhanViens.Any(x => x.CCCD == nv.CCCD))
                    throw new Exception("Mã CCCD đã tồn tại trong hệ thống!");

                int newId = DbHelper.MockDb.NhanViens.Count > 0 ? DbHelper.MockDb.NhanViens.Max(x => x.MaNV) + 1 : 1;
                nv.MaNV = newId;
                var pb = DbHelper.MockDb.PhongBans.FirstOrDefault(p => p.MaPB == nv.MaPB);
                nv.TenPB = pb?.TenPB ?? "";
                DbHelper.MockDb.NhanViens.Add(new NhanVienDTO
                {
                    MaNV = newId,
                    HoTen = nv.HoTen,
                    NgaySinh = nv.NgaySinh,
                    CCCD = nv.CCCD,
                    MaPB = nv.MaPB,
                    TenPB = nv.TenPB,
                    LuongCoBan = nv.LuongCoBan,
                    HeSoLuong = nv.HeSoLuong
                });
                return true;
            }

            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    INSERT INTO NhanVien (HoTen, NgaySinh, CCCD, MaPB, LuongCoBan, HeSoLuong)
                    VALUES (@HoTen, @NgaySinh, @CCCD, @MaPB, @LuongCoBan, @HeSoLuong)";
                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@HoTen", SqlDbType.NVarChar, 100) { Value = nv.HoTen });
                cmd.Parameters.Add(new SqlParameter("@NgaySinh", SqlDbType.DateTime) { Value = (object?)nv.NgaySinh ?? DBNull.Value });
                cmd.Parameters.Add(new SqlParameter("@CCCD", SqlDbType.VarChar, 20) { Value = nv.CCCD });
                cmd.Parameters.Add(new SqlParameter("@MaPB", SqlDbType.Int) { Value = nv.MaPB });
                cmd.Parameters.Add(new SqlParameter("@LuongCoBan", SqlDbType.Decimal) { Value = nv.LuongCoBan });
                cmd.Parameters.Add(new SqlParameter("@HeSoLuong", SqlDbType.Float) { Value = nv.HeSoLuong });
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Update(NhanVienDTO nv)
        {
            if (!DbHelper.CheckDatabaseConnection())
            {
                var exist = DbHelper.MockDb.NhanViens.FirstOrDefault(x => x.MaNV == nv.MaNV);
                if (exist == null) throw new Exception("Không tìm thấy nhân viên cần sửa!");
                if (DbHelper.MockDb.NhanViens.Any(x => x.CCCD == nv.CCCD && x.MaNV != nv.MaNV))
                    throw new Exception("Mã CCCD bị trùng với nhân viên khác!");

                var pb = DbHelper.MockDb.PhongBans.FirstOrDefault(p => p.MaPB == nv.MaPB);
                exist.HoTen = nv.HoTen;
                exist.NgaySinh = nv.NgaySinh;
                exist.CCCD = nv.CCCD;
                exist.MaPB = nv.MaPB;
                exist.TenPB = pb?.TenPB ?? "";
                exist.LuongCoBan = nv.LuongCoBan;
                exist.HeSoLuong = nv.HeSoLuong;
                return true;
            }

            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    UPDATE NhanVien 
                    SET HoTen = @HoTen, NgaySinh = @NgaySinh, CCCD = @CCCD, MaPB = @MaPB, LuongCoBan = @LuongCoBan, HeSoLuong = @HeSoLuong
                    WHERE MaNV = @MaNV";
                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@MaNV", SqlDbType.Int) { Value = nv.MaNV });
                cmd.Parameters.Add(new SqlParameter("@HoTen", SqlDbType.NVarChar, 100) { Value = nv.HoTen });
                cmd.Parameters.Add(new SqlParameter("@NgaySinh", SqlDbType.DateTime) { Value = (object?)nv.NgaySinh ?? DBNull.Value });
                cmd.Parameters.Add(new SqlParameter("@CCCD", SqlDbType.VarChar, 20) { Value = nv.CCCD });
                cmd.Parameters.Add(new SqlParameter("@MaPB", SqlDbType.Int) { Value = nv.MaPB });
                cmd.Parameters.Add(new SqlParameter("@LuongCoBan", SqlDbType.Decimal) { Value = nv.LuongCoBan });
                cmd.Parameters.Add(new SqlParameter("@HeSoLuong", SqlDbType.Float) { Value = nv.HeSoLuong });
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(int maNV)
        {
            if (!DbHelper.CheckDatabaseConnection())
            {
                var exist = DbHelper.MockDb.NhanViens.FirstOrDefault(x => x.MaNV == maNV);
                if (exist != null)
                {
                    DbHelper.MockDb.NhanViens.Remove(exist);
                    return true;
                }
                return false;
            }

            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM NhanVien WHERE MaNV = @MaNV";
                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@MaNV", SqlDbType.Int) { Value = maNV });
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
