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
            command.CommandText = "DELETE from KhachHang where MaKH='" + txtma.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "UPDATE KhachHang set TenKH = N'"+txtten.Text+"',SDT ='"+txtSDT.Text+"',GioiTinh = N'"+cmbgioitinh.Text+"',DiaChi = N'"+txtdiachi.Text+"',SoDiem = '"+txtdiem.Text+"',NamSinh = CONVERT(DATE,'" + dtnamsinh.Text + "',103),Email='" + txtEmail.Text+"' where MaKH= '"+txtma.Text+"'";
            command.ExecuteNonQuery();
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
    }
}
