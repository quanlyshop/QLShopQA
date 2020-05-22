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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strcConnection);
            conn.Open();
            string sql= "Select Count(*) from account where usename = '" + txtAccount.Text + "' and pass = '" + txtPassword.Text + "'";
            command = new SqlCommand(sql, conn);
            int x = (int)command.ExecuteScalar();
            if (x == 1)
            {
                MessageBox.Show("Đăng nhập thành công", "Đăng nhập");

            }
            else
            {
                MessageBox.Show("\tĐăng nhập thất bại\nSai mặt khẩu hoặc tên đăng nhập", "Faile");

            }
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
    }
}
