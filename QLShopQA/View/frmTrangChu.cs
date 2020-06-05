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
        public void DisEndMenuLogin(bool e,string _idLogin)
        {
            btnDSNhanVien.Enabled = !e;
            btnDangNhap.Enabled = e;
            btnLogout.Enabled = !e;
            btnPhanQuyen.Enabled = !e;
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
            //if (MessageBox.Show("Bạn có muốn đăng xuất !", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1))
            //{
            //    DisEndMenuLogin(true, idLogin);
            //    btnDangNhap_ItemClick(sender, e);
            //}
        }
    }
}