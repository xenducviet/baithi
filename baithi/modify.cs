using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Data.Common;

namespace baithi
{
    internal class modify
    {
        SqlDataAdapter dataAdapter; // truy xuất dữ liệu vào bảng
        SqlCommand sqlCommand; // dùng để truy vấn và cập nhật CSDL

        public modify()
        {
        }

        public DataTable getAllTHONGTINSINHVIEN()
        {
            DataTable datatable = new DataTable();
            string query = "select * from THONGTINSINHVIEN";
            using (SqlConnection sqlConnection = connection.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(datatable);
                sqlConnection.Close();
            }
            return datatable;
        }

        public bool insert(THONGTINSINHVIEN tHONGTINSINHVIEN)
        {
            SqlConnection sqlConnection = connection.getConnection();
            string query = "insert into THONGTINSINHVIEN values(@MASV,@TENSV,@MALOP,@MAKHOA,@NGAYSINH,@GIOITINH,@DIACHI,@SDT)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MASV", SqlDbType.NVarChar).Value = tHONGTINSINHVIEN.Masv;
                sqlCommand.Parameters.Add("@TENSV", SqlDbType.NVarChar).Value = tHONGTINSINHVIEN.Tensv;
                sqlCommand.Parameters.Add("@MALOP", SqlDbType.NVarChar).Value = tHONGTINSINHVIEN.Malop;
                sqlCommand.Parameters.Add("@MAKHOA", SqlDbType.NVarChar).Value = tHONGTINSINHVIEN.Makhoa;
                sqlCommand.Parameters.Add("@NGAYSINH", SqlDbType.DateTime).Value = tHONGTINSINHVIEN.Ngaysinh.ToShortDateString();
                sqlCommand.Parameters.Add("@GIOITINH", SqlDbType.NVarChar).Value = tHONGTINSINHVIEN.Gioitinh;
                sqlCommand.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = tHONGTINSINHVIEN.Diachi;
                sqlCommand.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = tHONGTINSINHVIEN.Sdt;

                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }

        }
        public bool update(THONGTINSINHVIEN tHONGTINSINHVIEN)
        {

            SqlConnection sqlConnection = connection.getConnection();
            string query = "UPDATE THONGTINSINHVIEN set  Tensv = @TENSV, Malop = @MALOP, Makhoa = @MAKHOA, Ngaysinh = @NGAYSINH, Gioitinh = @GIOITINH, Diachi = @DIACHI, Sdt = @SDT WHERE Masv=@MASV";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MASV", SqlDbType.NVarChar).Value = tHONGTINSINHVIEN.Masv;
                sqlCommand.Parameters.Add("@TENSV", SqlDbType.NVarChar).Value = tHONGTINSINHVIEN.Tensv;
                sqlCommand.Parameters.Add("@MALOP", SqlDbType.NVarChar).Value = tHONGTINSINHVIEN.Malop;
                sqlCommand.Parameters.Add("@MAKHOA", SqlDbType.NVarChar).Value = tHONGTINSINHVIEN.Makhoa;
                sqlCommand.Parameters.Add("@NGAYSINH", SqlDbType.DateTime).Value = tHONGTINSINHVIEN.Ngaysinh;
                sqlCommand.Parameters.Add("@GIOITINH", SqlDbType.NVarChar).Value = tHONGTINSINHVIEN.Gioitinh;
                sqlCommand.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = tHONGTINSINHVIEN.Diachi;
                sqlCommand.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = tHONGTINSINHVIEN.Sdt;

                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        public bool delete(string Masv)
        {

            SqlConnection sqlConnection = connection.getConnection();
            string query = "delete THONGTINSINHVIEN  WHERE Masv=@MASV";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MASV", SqlDbType.NVarChar).Value = Masv;
               

                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
