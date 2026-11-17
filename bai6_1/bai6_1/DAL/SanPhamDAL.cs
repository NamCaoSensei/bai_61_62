using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Microsoft.Data.SqlClient;
using bai6_1.DTO;

namespace bai6_1.DAL
{
    public class SanPhamDAL
    {
        public List<SanPhamDTO> GetAll()
        {
            if (!DbHelper.CheckDatabaseConnection())
            {
                return DbHelper.MockDb.SanPhams.Select(s => new SanPhamDTO
                {
                    MaSP = s.MaSP,
                    TenSP = s.TenSP,
                    GiaBan = s.GiaBan,
                    SoLuongTon = s.SoLuongTon
                }).ToList();
            }

            var list = new List<SanPhamDTO>();
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT MaSP, TenSP, GiaBan, SoLuongTon FROM SanPham ORDER BY MaSP";
                using var cmd = new SqlCommand(query, conn);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new SanPhamDTO
                    {
                        MaSP = reader["MaSP"].ToString() ?? "",
                        TenSP = reader["TenSP"].ToString() ?? "",
                        GiaBan = Convert.ToDecimal(reader["GiaBan"]),
                        SoLuongTon = Convert.ToInt32(reader["SoLuongTon"])
                    });
                }
            }
            return list;
        }

        public List<SanPhamDTO> Search(string keyword)
        {
            if (!DbHelper.CheckDatabaseConnection())
            {
                var kw = (keyword ?? "").Trim();
                return DbHelper.MockDb.SanPhams
                    .Where(s => s.MaSP.Contains(kw, StringComparison.OrdinalIgnoreCase) ||
                                s.TenSP.Contains(kw, StringComparison.OrdinalIgnoreCase))
                    .Select(s => new SanPhamDTO
                    {
                        MaSP = s.MaSP,
                        TenSP = s.TenSP,
                        GiaBan = s.GiaBan,
                        SoLuongTon = s.SoLuongTon
                    }).ToList();
            }

            var list = new List<SanPhamDTO>();
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                // Phòng chống 100% SQL Injection bằng SqlParameter có ký tự đại diện %
                string query = "SELECT MaSP, TenSP, GiaBan, SoLuongTon FROM SanPham WHERE MaSP LIKE @Keyword OR TenSP LIKE @Keyword";
                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@Keyword", SqlDbType.NVarChar) { Value = $"%{keyword.Trim()}%" });

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new SanPhamDTO
                    {
                        MaSP = reader["MaSP"].ToString() ?? "",
                        TenSP = reader["TenSP"].ToString() ?? "",
                        GiaBan = Convert.ToDecimal(reader["GiaBan"]),
                        SoLuongTon = Convert.ToInt32(reader["SoLuongTon"])
                    });
                }
            }
            return list;
        }

        public bool Insert(SanPhamDTO sp)
        {
            if (!DbHelper.CheckDatabaseConnection())
            {
                if (DbHelper.MockDb.SanPhams.Any(x => x.MaSP.Equals(sp.MaSP, StringComparison.OrdinalIgnoreCase)))
                    throw new Exception("Mã sản phẩm đã tồn tại trong hệ thống!");
                DbHelper.MockDb.SanPhams.Add(new SanPhamDTO
                {
                    MaSP = sp.MaSP,
                    TenSP = sp.TenSP,
                    GiaBan = sp.GiaBan,
                    SoLuongTon = sp.SoLuongTon
                });
                return true;
            }

            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO SanPham (MaSP, TenSP, GiaBan, SoLuongTon) VALUES (@MaSP, @TenSP, @GiaBan, @SoLuongTon)";
                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@MaSP", SqlDbType.VarChar, 20) { Value = sp.MaSP });
                cmd.Parameters.Add(new SqlParameter("@TenSP", SqlDbType.NVarChar, 150) { Value = sp.TenSP });
                cmd.Parameters.Add(new SqlParameter("@GiaBan", SqlDbType.Decimal) { Value = sp.GiaBan });
                cmd.Parameters.Add(new SqlParameter("@SoLuongTon", SqlDbType.Int) { Value = sp.SoLuongTon });
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Update(SanPhamDTO sp)
        {
            if (!DbHelper.CheckDatabaseConnection())
            {
                var exist = DbHelper.MockDb.SanPhams.FirstOrDefault(x => x.MaSP.Equals(sp.MaSP, StringComparison.OrdinalIgnoreCase));
                if (exist == null) throw new Exception("Không tìm thấy sản phẩm cần cập nhật!");
                exist.TenSP = sp.TenSP;
                exist.GiaBan = sp.GiaBan;
                exist.SoLuongTon = sp.SoLuongTon;
                return true;
            }

            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                string query = "UPDATE SanPham SET TenSP = @TenSP, GiaBan = @GiaBan, SoLuongTon = @SoLuongTon WHERE MaSP = @MaSP";
                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@MaSP", SqlDbType.VarChar, 20) { Value = sp.MaSP });
                cmd.Parameters.Add(new SqlParameter("@TenSP", SqlDbType.NVarChar, 150) { Value = sp.TenSP });
                cmd.Parameters.Add(new SqlParameter("@GiaBan", SqlDbType.Decimal) { Value = sp.GiaBan });
                cmd.Parameters.Add(new SqlParameter("@SoLuongTon", SqlDbType.Int) { Value = sp.SoLuongTon });
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(string maSP)
        {
            if (!DbHelper.CheckDatabaseConnection())
            {
                var exist = DbHelper.MockDb.SanPhams.FirstOrDefault(x => x.MaSP.Equals(maSP, StringComparison.OrdinalIgnoreCase));
                if (exist != null)
                {
                    DbHelper.MockDb.SanPhams.Remove(exist);
                    return true;
                }
                return false;
            }

            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM SanPham WHERE MaSP = @MaSP";
                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@MaSP", SqlDbType.VarChar, 20) { Value = maSP });
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
