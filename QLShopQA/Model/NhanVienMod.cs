using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QLShopQA.Object;
using QLShopQA.View;
using QLShopQA.Control;


namespace QLShopQA.Model
{
    class NhanVienMod
    {
        SqlConnection connection;
        SqlCommand command;
        //string str = @"Data Source=DESKTOP-AB4A8OE;Initial Catalog=QL_ShopQuanAo;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        //ConnectToSQL con = new ConnectToSQL();
        //SqlCommand cmd = new SqlCommand();
        ////SqlConnection con = new SqlConnection;

        //public DataTable GetData()
        //{
        //    DataTable dt = new DataTable();
        //    cmd.CommandText = "select *from tb_NhanVien";
        //    cmd.CommandType = CommandType.Text;
        //    cmd.Connection = con.Connection;
        //    try
        //    {
        //        con.OpenConn();//Mở kết nối
        //        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        //        sda.Fill(dt);//lấy dữ liệu
        //        con.CloseConn();
        //    }
        //    catch(Exception ex)
        //    {
        //        //Nếu xảy ra lỗi
        //        string mex = ex.Message;
        //        cmd.Dispose();//cmd còn ở trong phien lam viec nen xoa bo no di

        //        con.CloseConn();
        //    }
        //    return dt;
        //}
    

        public bool AddData(NhanVienObj nvobj)
        {
            command = connection.CreateCommand();
            //command.CommandText = "Insert into tb_NhanVien values ('" + txtma.Text + "', N'" + txtten.Text + "', N'" + cmbgioitinh.Text + "', N'" + txtdiachi.Text + "','" + txtSDT.Text + "','" + dtnamsinh.Text + "',)";
            //command.ExecuteNonQuery();
            command.CommandText = "Insert into tb_NhanVien values ('" + nvobj.MaNhanVien + "', N'" + nvobj.TenNhanVien + "', N'" + nvobj.Gioitinh + "',CONVERT(DATE,'" + nvobj.Namsinh + "',103), N'" + nvobj.Diachi + "','" + nvobj.SDT + "','" + nvobj.Matkhau+ "')";
            //cmd.CommandType = CommandType.Text;
            //cmd.Connection = con.Connection;
            try
            {
                connection.Open();
                command.ExecuteNonQuery();  
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                command.Dispose();//cmd trong phien lam viec nen xoa bo no di
                connection.Close();
            }
            return false;
        }

        public bool UpdData(NhanVienObj nvobj)
        {
            command = connection.CreateCommand();
            command.CommandText = "Update tb_NhanVien set TenNhanVien= N'" + nvobj.TenNhanVien + "', GioiTinh= N'" + nvobj.Gioitinh + "', DiaChi = N'" + nvobj.Diachi + "',SDT = '" + nvobj.SDT + "',NamSinh = CONVERT(DATE,'" + nvobj.Namsinh + "',103) where MaNV='" + nvobj.MaNhanVien+"'";
            command.CommandType = CommandType.Text;                                                                                                                                                      
            //command.Connection = connection.Connection;
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                command.Dispose();//cmd trong phien lam viec nen xoa bo no di

                connection.Close();
            }
            return false;
        }

        public bool DelData(string ma)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete tb_NhanVien where MaNV = '"+ma+"'";
            command.CommandType = CommandType.Text;
            //command.Connection = con.Connection;
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                command.Dispose();//cmd trong phien lam viec nen xoa bo no di
                connection.Close();
            }
            return false;
        }
    }
}
