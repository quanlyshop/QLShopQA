using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;

namespace QLShopQA.View
{
    public partial class frmTrangChu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static string idLogin;//phat trien phan quyen
        public static string user;
        public frmTrangChu()
        {
            InitializeComponent();
            //DisEndMenuLogin(true,idLogin);
        }
        public void DisEndMenuLogin(bool e)
        {
            btnDSNhanVien.Enabled= btnDSKhachHang.Enabled = btnPhanQuyen.Enabled = btnRegister.Enabled =e;
            btnDangNhap.Enabled =!e;
            //btnLogout.Enabled = !e;
            //btnPhanQuyen.Enabled = !e;
            //btnRegister.Enabled = !e;
            //btnDSKhachHang.Enabled = !e;
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {

        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }
        private Form KiemTraTonTai(Type ftype)
        {
            foreach(Form f in this.MdiChildren)
            {
                if(f.GetType() == ftype) //neu form duoc truyen vao da dc mo
                {
                    return f;
                }
            }
            return null;
        }
        public void get_permission(int per)
        {
            if (per == 1)
            {
                DisEndMenuLogin(true);
                btnLogout.Enabled = true;
            }
            else
                DisEndMenuLogin(false);
                btnLogout.Enabled = true;
        }
        private void btnDSNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmNhanVien));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmNhanVien f = new frmNhanVien();
                f.MdiParent = this;
                f.Show();
            }
        }
        
        private void btnDangNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmLogin));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmLogin f = new frmLogin();
                f.MdiParent = this;
                f.Show();
            }


        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn đăng xuất !", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1))
            {
                DisEndMenuLogin(true);
                btnDangNhap_ItemClick(sender, e);
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmKhachHang));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmKhachHang f = new frmKhachHang();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}