using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinForms
{
    public partial class LoginForm : Form
    {
        public static string password;

        public LoginForm()
        {
            InitializeComponent();
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("pass.txt");
            password = sr.ReadToEnd();
            lblWrong.Visible = false;
            sr.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == password)
            {
                lblWrong.Visible = false;
                Selection selection = new Selection(this);
                selection.Show();
                Visible = false;
            }
            else
            {
                lblWrong.Visible = true;
            }

            txtPass.Text = "";
        }
    }
}
