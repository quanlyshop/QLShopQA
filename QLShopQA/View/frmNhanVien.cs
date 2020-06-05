using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraEditors;

namespace QLShopQA.View
{
    public partial class frmNhanVien : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-AB4A8OE;Initial Catalog=QL_ShopQuanAo;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
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
            connection = new SqlConnection(str);
            connection.Open();
            loadcontrol();
        }
        //void bingding()
        //{   
        //    txtma.DataBindings.Clear();
        //    txtma.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "Manv");

        //    txtten.DataBindings.Clear();
        //    txtten.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "TenNhanVien");

        //    txtdiachi.DataBindings.Clear();
        //    txtdiachi.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "DiaChi");

        //    txtSDT.DataBindings.Clear();
        //    txtSDT.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "SDT");

        //    dtnamsinh.DataBindings.Clear();
        //    dtnamsinh.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "NamSinh");

        //    cmbgioitinh.DataBindings.Clear();
        //    cmbgioitinh.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "GioiTinh");
           
        //}
        //void dis_en(bool e)
        //{
        //    txtma.Enabled = e;
        //    txtten.Enabled = e;
        //    txtdiachi.Enabled = e;
        //    txtSDT.Enabled = e;
        //    dtnamsinh.Enabled = e;
        //    cmbgioitinh.Enabled = e;
        //    btnLuu.Enabled = e;
        //    btnHuy.Enabled = e;
        //    btnThem.Enabled = !e;
        //    btnSua.Enabled = !e;
        //    btnXoa.Enabled = !e;
        //}
        void loadcontrol()
        {
            command = connection.CreateCommand();
            command.CommandText = "select *from NhanVien";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvDanhSachNV.DataSource = table;
        }
        private void dgvDanhSachNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvDanhSachNV.CurrentRow.Index;
            txtma.Text = dgvDanhSachNV.Rows[i].Cells[0].Value.ToString();
            txtten.Text = dgvDanhSachNV.Rows[i].Cells[1].Value.ToString();
            dtnamsinh.Text = dgvDanhSachNV.Rows[i].Cells[5].Value.ToString();
            cmbgioitinh.Text = dgvDanhSachNV.Rows[i].Cells[2].Value.ToString();
            txtdiachi.Text = dgvDanhSachNV.Rows[i].Cells[3].Value.ToString();
            txtSDT.Text = dgvDanhSachNV.Rows[i].Cells[4].Value.ToString();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "Insert into tb_NhanVien values ('" + txtma.Text + "', N'" + txtten.Text + "', N'" + cmbgioitinh.Text + "', N'" + txtdiachi.Text + "','" + txtSDT.Text + "','" + dtnamsinh.Text + "',)";
            command.ExecuteNonQuery();            
            loadcontrol();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "UPDATE NhanVien set TenNV = N'" + txtten.Text + "',GioiTinh = N'" + cmbgioitinh.Text + "',DiaChi = N'" + txtdiachi.Text + "',SDT = '" + txtSDT.Text + "',NamSinh = '" + dtnamsinh.Text + "'";
            command.ExecuteNonQuery();
            loadcontrol();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //command = connection.CreateCommand();
            //command.CommandText = "DELETE from NhanVien where MaNV='" + txtma.Text + "'";
            //command.ExecuteNonQuery();
            //loadcontrol();
            DialogResult dr = XtraMessageBox.Show("Bạn có muốn xóa ?", " Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                command = connection.CreateCommand();
                command.CommandText = "DELETE from NhanVien where MaNV='" + txtma.Text + "'";
                command.ExecuteNonQuery();
                loadcontrol();
                XtraMessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                return;
            frmNhanVien_Load(sender, e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //ganDuLieu(nvObj);
            //if (flag == 0)
            //{
            //    if (nvctr.addData(nvObj))
            //        XtraMessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    else
            //        XtraMessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{
            //    if (nvctr.updData(nvObj))
            //        XtraMessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    else
            //        XtraMessageBox.Show("Sửa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //frmNhanVien_Load(sender, e);//lưu xong load lại
            //dis_en(false);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtma.Text = "";
            txtten.Text = "";
            txtSDT.Text = "";
            cmbgioitinh.Text = "";
            txtdiachi.Text = "";         
            dtnamsinh.Text = "1/1/1999";         
            //frmNhanVien_Load(sender, e);
            //dis_en(false);
        }

        private void cmbgioitinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
