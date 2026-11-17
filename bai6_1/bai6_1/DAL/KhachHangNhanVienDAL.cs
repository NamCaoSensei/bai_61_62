using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Microsoft.Data.SqlClient;
using bai6_1.DTO;

namespace bai6_1.DAL
{
    public class KhachHangDAL
    {
        public List<KhachHangDTO> GetAll()
        {
            if (!DbHelper.CheckDatabaseConnection())
            {
                return DbHelper.MockDb.KhachHangs.Select(k => new KhachHangDTO
                {
                    MaKH = k.MaKH,
                    TenKH = k.TenKH,
                    DienThoai = k.DienThoai,
                    DiemTichLuy = k.DiemTichLuy
                }).ToList();
            }

            var list = new List<KhachHangDTO>();
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT MaKH, TenKH, DienThoai, DiemTichLuy FROM KhachHang ORDER BY MaKH";
                using var cmd = new SqlCommand(query, conn);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new KhachHangDTO
                    {
                        MaKH = Convert.ToInt32(reader["MaKH"]),
                        TenKH = reader["TenKH"].ToString() ?? "",
                        DienThoai = reader["DienThoai"].ToString() ?? "",
                        DiemTichLuy = Convert.ToInt32(reader["DiemTichLuy"])
                    });
                }
            }
            return list;
        }

        public bool Insert(KhachHangDTO kh)
        {
            if (!DbHelper.CheckDatabaseConnection())
            {
                int newId = DbHelper.MockDb.KhachHangs.Count > 0 ? DbHelper.MockDb.KhachHangs.Max(x => x.MaKH) + 1 : 1;
                kh.MaKH = newId;
                DbHelper.MockDb.KhachHangs.Add(new KhachHangDTO
                {
                    MaKH = newId,
                    TenKH = kh.TenKH,
                    DienThoai = kh.DienThoai,
                    DiemTichLuy = kh.DiemTichLuy
                });
                return true;
            }

            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO KhachHang (TenKH, DienThoai, DiemTichLuy) VALUES (@TenKH, @DienThoai, @DiemTichLuy)";
                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@TenKH", SqlDbType.NVarChar, 100) { Value = kh.TenKH });
                cmd.Parameters.Add(new SqlParameter("@DienThoai", SqlDbType.VarChar, 15) { Value = kh.DienThoai });
                cmd.Parameters.Add(new SqlParameter("@DiemTichLuy", SqlDbType.Int) { Value = kh.DiemTichLuy });
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Update(KhachHangDTO kh)
        {
            if (!DbHelper.CheckDatabaseConnection())
            {
                var exist = DbHelper.MockDb.KhachHangs.FirstOrDefault(x => x.MaKH == kh.MaKH);
                if (exist == null) throw new Exception("Không tìm thấy khách hàng cần sửa!");
                exist.TenKH = kh.TenKH;
                exist.DienThoai = kh.DienThoai;
                exist.DiemTichLuy = kh.DiemTichLuy;
                return true;
            }

            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                string query = "UPDATE KhachHang SET TenKH = @TenKH, DienThoai = @DienThoai, DiemTichLuy = @DiemTichLuy WHERE MaKH = @MaKH";
                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@MaKH", SqlDbType.Int) { Value = kh.MaKH });
                cmd.Parameters.Add(new SqlParameter("@TenKH", SqlDbType.NVarChar, 100) { Value = kh.TenKH });
                cmd.Parameters.Add(new SqlParameter("@DienThoai", SqlDbType.VarChar, 15) { Value = kh.DienThoai });
                cmd.Parameters.Add(new SqlParameter("@DiemTichLuy", SqlDbType.Int) { Value = kh.DiemTichLuy });
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(int maKH)
        {
            if (!DbHelper.CheckDatabaseConnection())
            {
                var exist = DbHelper.MockDb.KhachHangs.FirstOrDefault(x => x.MaKH == maKH);
                if (exist != null)
                {
                    DbHelper.MockDb.KhachHangs.Remove(exist);
                    return true;
                }
                return false;
            }

            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM KhachHang WHERE MaKH = @MaKH";
                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@MaKH", SqlDbType.Int) { Value = maKH });
                return cmd.ExecuteNonQuery() > 0;
            }
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
                    TenNV = n.TenNV,
                    SoDienThoai = n.SoDienThoai,
                    ChucVu = n.ChucVu
                }).ToList();
            }

            var list = new List<NhanVienDTO>();
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT MaNV, TenNV, SoDienThoai, ChucVu FROM NhanVien ORDER BY MaNV";
                using var cmd = new SqlCommand(query, conn);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new NhanVienDTO
                    {
                        MaNV = Convert.ToInt32(reader["MaNV"]),
                        TenNV = reader["TenNV"].ToString() ?? "",
                        SoDienThoai = reader["SoDienThoai"].ToString() ?? "",
                        ChucVu = reader["ChucVu"].ToString() ?? ""
                    });
                }
            }
            return list;
        }

        public bool Insert(NhanVienDTO nv)
        {
            if (!DbHelper.CheckDatabaseConnection())
            {
                int newId = DbHelper.MockDb.NhanViens.Count > 0 ? DbHelper.MockDb.NhanViens.Max(x => x.MaNV) + 1 : 1;
                nv.MaNV = newId;
                DbHelper.MockDb.NhanViens.Add(new NhanVienDTO
                {
                    MaNV = newId,
                    TenNV = nv.TenNV,
                    SoDienThoai = nv.SoDienThoai,
                    ChucVu = nv.ChucVu
                });
                return true;
            }

            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO NhanVien (TenNV, SoDienThoai, ChucVu) VALUES (@TenNV, @SoDienThoai, @ChucVu)";
                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@TenNV", SqlDbType.NVarChar, 100) { Value = nv.TenNV });
                cmd.Parameters.Add(new SqlParameter("@SoDienThoai", SqlDbType.VarChar, 15) { Value = nv.SoDienThoai });
                cmd.Parameters.Add(new SqlParameter("@ChucVu", SqlDbType.NVarChar, 50) { Value = nv.ChucVu });
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Update(NhanVienDTO nv)
        {
            if (!DbHelper.CheckDatabaseConnection())
            {
                var exist = DbHelper.MockDb.NhanViens.FirstOrDefault(x => x.MaNV == nv.MaNV);
                if (exist == null) throw new Exception("Không tìm thấy nhân viên cần sửa!");
                exist.TenNV = nv.TenNV;
                exist.SoDienThoai = nv.SoDienThoai;
                exist.ChucVu = nv.ChucVu;
                return true;
            }

            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                string query = "UPDATE NhanVien SET TenNV = @TenNV, SoDienThoai = @SoDienThoai, ChucVu = @ChucVu WHERE MaNV = @MaNV";
                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@MaNV", SqlDbType.Int) { Value = nv.MaNV });
                cmd.Parameters.Add(new SqlParameter("@TenNV", SqlDbType.NVarChar, 100) { Value = nv.TenNV });
                cmd.Parameters.Add(new SqlParameter("@SoDienThoai", SqlDbType.VarChar, 15) { Value = nv.SoDienThoai });
                cmd.Parameters.Add(new SqlParameter("@ChucVu", SqlDbType.NVarChar, 50) { Value = nv.ChucVu });
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
