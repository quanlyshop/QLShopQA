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

namespace QLShopQA.View
{
    public partial class frmLogin : Form
    {
        //frmNhanVien frm;
        string strcConnection = @"Data Source=DESKTOP-AB4A8OE;Initial Catalog=QL_ShopQuanAo;Integrated Security=True";
        SqlConnection conn;
        SqlCommand command;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
        public delegate void CheckpPermission(int per);
        CheckpPermission chk;
        frmTrangChu frm;
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strcConnection);
            conn.Open();
            string sql= "Select Count(*) from account where usename = '" + txtAccount.Text + "' and pass = '" + txtPassword.Text + "'";
            command = new SqlCommand(sql, conn);
            int x = (int)command.ExecuteScalar();
            if (x == 1)
            {
                frmTrangChu frm = new frmTrangChu();
                chk = new CheckpPermission(frm.get_permission);
                //MessageBox.Show("Đăng nhập thành công", "Đăng nhập");
                //frmTrangChu f = new frmTrangChu();
                if (txtAccount.Text == "admin")
                {
                    chk(1);
                }
                else
                    chk(0);
                this.Hide();
                frm.ShowDialog();//Đợi cho showdialog tắt đi mới chạy tiếp
                this.Show();
            }
            else
            {
                //MessageBox.Show("\tĐăng nhập thất bại\nSai mặt khẩu hoặc tên đăng nhập", "Faile");
                lblIncorrect.Text = "Bạn đã nhập sai tên đăng nhập hoặc mặc khẩu";
                txtAccount.Text = "";
                txtPassword.Text = "";
                txtAccount.Focus();
            }
            //frmTrangChu f = new frmTrangChu();
            //this.Hide();
            //f.ShowDialog();//Đợi cho showdialog tắt đi mới chạy tiếp
            //this.Show();

        }
        

        private void ckbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát chương trình ?","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)!=System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
