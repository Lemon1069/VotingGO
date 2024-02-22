using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinForms
{
    public partial class Selection : Form
    {
        private LoginForm loginForm;
        public Selection(LoginForm loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
        }

        private void Selection_Load(object sender, EventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            VotingForm votingForm = new VotingForm(loginForm);
            votingForm.Show();
            Close();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Vote vote = new Vote();
            vote.Show();
            Close();
        }
    }
}
