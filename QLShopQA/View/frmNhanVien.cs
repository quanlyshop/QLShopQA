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


namespace QLShopQA.View
{
    public partial class frmNhanVien : Form
    {
        NhanVienCtrl nvctr = new NhanVienCtrl();
        NhanVienObj nvObj = new NhanVienObj();  
        int flag = 0;
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
        void dis_en(bool e)
        {
            txtma.Enabled = e;
            txtten.Enabled = e;
            txtdiachi.Enabled = e;
            txtSDT.Enabled = e;
            dtnamsinh.Enabled = e;
            cmbgioitinh.Enabled = e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
        
        }
        void ganDuLieu(NhanVienObj nvObj)
        {
            nvObj.MaNhanVien = txtma.Text.Trim();
            nvObj.TenNhanVien = txtten.Text.Trim();
            nvObj.Namsinh = dtnamsinh.Text.Trim();
            nvObj.Gioitinh = cmbgioitinh.Text;
            nvObj.Diachi = txtdiachi.Text.Trim();
            nvObj.SDT = txtSDT.Text.Trim();
            nvObj.Matkhau = "";

        }
        void loadcontrol()
        {
            cmbgioitinh.Items.Add("Nam");
            cmbgioitinh.Items.Add("Nu");
            dtnamsinh.Text = DateTime.Now.Date.ToShortDateString();
            
        }
        private void dgvDanhSachNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            flag = 0;

            dis_en(true);
            loadcontrol();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_en(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure ?", " xac nhan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (nvctr.delData(txtma.Text.Trim()))
                    MessageBox.Show("Xoa thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else 
                    MessageBox.Show("Xoa that bai", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                return;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ganDuLieu(nvObj);
            if (flag == 0)
            {
                if (nvctr.addData(nvObj))
                    MessageBox.Show("Them thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Them that bai", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (nvctr.updData(nvObj))
                    MessageBox.Show("Sua thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sua that bai", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmNhanVien_Load(sender, e);
            dis_en(false);
        }

        private void cmbgioitinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
