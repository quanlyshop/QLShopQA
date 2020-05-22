using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QLShopQA.Object;


namespace QLShopQA.Model
{
    class NhanVienMod
    {
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();
        //SqlConnection con = new SqlConnection;

        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select *from tb_NhanVien";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                con.CloseConn();
            }
            catch(Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();//cmd trong phien lam viec nen xoa bo no di

                con.CloseConn();
            }
            return dt;
        }

        public bool AddData(NhanVienObj nvobj)
        {
            cmd.CommandText = "Insert into tb_NhanVien values ('"+nvobj.MaNhanVien+"','"+ nvobj.TenNhanVien + "','" + nvobj.Gioitinh + "',CONVERT(DATE,'" + nvobj.Namsinh + "',103),'" + nvobj.Diachi + "','" + nvobj.SDT + "','" + nvobj.Matkhau+ "')";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                con.CloseConn();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();//cmd trong phien lam viec nen xoa bo no di

                con.CloseConn();
            }
            return false;
        }

        public bool UpdateData(NhanVienObj nvobj)
        {
            cmd.CommandText = "Update tb_NhanVien set TenNhanVien='" + nvobj.TenNhanVien + "',set GioiTinh='" + nvobj.Gioitinh + "',NamSinh = CONVERT(DATE,'" + nvobj.Namsinh + "',103),DiaChi = '" + nvobj.Diachi + "',SDT = '" + nvobj.SDT + "',MatKhau = '" + nvobj.Matkhau + "' where MaNV='"+nvobj.MaNhanVien+"'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                con.CloseConn();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();//cmd trong phien lam viec nen xoa bo no di

                con.CloseConn();
            }
            return false;
        }

        public bool DelData(string ma)
        {
            cmd.CommandText = "delete tb_NhanVien where MaNV = '"+ma+"'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                con.CloseConn();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();//cmd trong phien lam viec nen xoa bo no di

                con.CloseConn();
            }
            return false;
        }
    }
}
