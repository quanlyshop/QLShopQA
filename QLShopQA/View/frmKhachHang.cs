using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLShopQA.Control;
using QLShopQA.Model;
using System.Data.SqlClient;
using QLShopQA.Object;
using DevExpress.XtraEditors;
using System.Configuration;

namespace QLShopQA.View
{
    public partial class frmKhachHang : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-AB4A8OE;Initial Catalog=QL_ShopQuanAo;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select *from KhachHang";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvDanhSachKH.DataSource = table;
        }
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }
        //private void frmKhachHang_FormClosing(object sender,FormClosingEventArgs e)
        //{
        //    con.Close();
        //}
        //public void HienThi()
        //{
        //    string sqlSELECT = "select *from KhachHang";
        //    SqlCommand cmd = new SqlCommand(sqlSELECT, con);
        //    SqlDataReader dr = cmd.ExecuteReader();
        //    DataTable dt = new DataTable();
        //    dt.Load(dr);
        //    dgvDanhSachKH.DataSource = dt;
        //}

        private void btnThem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "INSERT into KhachHang values('" + txtma.Text + "', N'" + txtten.Text + "', '" + txtSDT.Text + "', N'" + cmbgioitinh.Text + "', N'" + txtdiachi.Text + "','" + txtdiem.Text + "','" + dtnamsinh.Text + "','"+ txtEmail.Text +"')";
            command.ExecuteNonQuery();
            XtraMessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loaddata();
        }

        private void dgvDanhSachKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvDanhSachKH.CurrentRow.Index;
            txtma.Text = dgvDanhSachKH.Rows[i].Cells[0].Value.ToString();
            txtten.Text = dgvDanhSachKH.Rows[i].Cells[1].Value.ToString();
            dtnamsinh.Text = dgvDanhSachKH.Rows[i].Cells[6].Value.ToString();
            cmbgioitinh.Text = dgvDanhSachKH.Rows[i].Cells[3].Value.ToString();
            txtdiem.Text = dgvDanhSachKH.Rows[i].Cells[5].Value.ToString();
            txtdiachi.Text = dgvDanhSachKH.Rows[i].Cells[4].Value.ToString();
            txtSDT.Text = dgvDanhSachKH.Rows[i].Cells[2].Value.ToString();
            txtEmail.Text = dgvDanhSachKH.Rows[i].Cells[7].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "DELETE from NhanVien where MaNV='" + txtma.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
            //DialogResult dr = XtraMessageBox.Show("Bạn có muốn xóa ?", " Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (dr == DialogResult.Yes)
            //{
            //command = connection.CreateCommand();
            //command.CommandText = "DELETE from NhanVien where MaNV='" + txtma.Text + "'";
            //command.ExecuteNonQuery();
            //loaddata();
            XtraMessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //    return;
            //frmKhachHang_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "UPDATE KhachHang set TenKH = N'"+txtten.Text+"',SDT ='"+txtSDT.Text+"',GioiTinh = N'"+cmbgioitinh.Text+"',DiaChi = N'"+txtdiachi.Text+"',SoDiem = '"+txtdiem.Text+"',NamSinh = CONVERT(DATE,'" + dtnamsinh.Text + "',103),Email='" + txtEmail.Text+"' where MaKH= '"+txtma.Text+"'";
            command.ExecuteNonQuery();
            XtraMessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loaddata();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtma.Text = "";
            txtten.Text = "";
            txtSDT.Text = "";
            cmbgioitinh.Text = "";
            txtdiachi.Text = "";
            txtdiem.Text = "";
            dtnamsinh.Text = "1/1/1999";
            txtEmail.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string sqlTimKiem = "slect *form KhachHang where MaKH= @ma.Text";
            //SqlCommand cmd = new SqlCommand(sqlTimKiem, connection);
            //cmd.Parameters.AddWithValue("MaKH", txtMaCanTim.Text);
            //cmd.Parameters.AddWithValue("TenKH", txtten.Text);
            //cmd.Parameters.AddWithValue("SDT", txtSDT.Text);
            //cmd.Parameters.AddWithValue("GioiTinh", cmbgioitinh.Text);
            //cmd.Parameters.AddWithValue("DiaChi", txtdiachi.Text);
            //cmd.Parameters.AddWithValue("SoDiem", txtdiem.Text);
            //cmd.Parameters.AddWithValue("NamSinh", dtnamsinh.Text);
            //cmd.Parameters.AddWithValue("Email", txtEmail.Text);
            //cmd.ExecuteNonQuery();
            //SqlDataReader dr = cmd.ExecuteReader();
            //DataTable dt = new DataTable();
            //dt.Load(dr);
            //dgvDanhSachKH.DataSource = dt;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
