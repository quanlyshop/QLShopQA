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


namespace QLShopQA.View
{
    public partial class frmNhanVien : Form
    {
        NhanVienCtrl nvctr = new NhanVienCtrl();
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-AB4A8OE;Initial Catalog=QL_ShopQuanAo;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from NhanVien", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);            
            DataTable dtNhanVien = new DataTable();
            da.Fill(dtNhanVien);
            dgvDanhSachNV.DataSource = dtNhanVien;
            //int i = 0;
            //foreach (DataRow dr in dtNhanVien.Rows)
            //{
            //    listView1.Items.Add(dr["MaNV"].ToString());
            //    listView1.Items[i].SubItems.Add(dr["TenNhanVien"].ToString());
            //    i++;
            //}
            //dtNhanVien = nvctr.getData();
            //dgvDanhSachNV.DataSource = dtNhanVien;
            //bingding();
            
        }
       void bingding()
        {   
            txtma.DataBindings.Clear();
            txtma.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "MaNV");

            txtten.DataBindings.Clear();
            txtten.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "TenNhanVien");

            txtdiachi.DataBindings.Clear();
            txtdiachi.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "DiaChi");

            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "SDT");

            dtnamsinh.DataBindings.Clear();
            dtnamsinh.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "NamSinh");

            cmbgioitinh.DataBindings.Clear();
            cmbgioitinh.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "GioiTinh");
           
        }

        private void dgvDanhSachNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
