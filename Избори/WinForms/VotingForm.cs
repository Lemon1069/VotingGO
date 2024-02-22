using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VotingActivities;
using Data;

namespace WinForms
{
    public partial class VotingForm : Form
    {
        private VotingSystem votingSystem = new VotingSystem();
        private LoginForm loginForm;

        public VotingForm(LoginForm loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
        }

        private void VotingForm_Load(object sender, EventArgs e)
        {
            btnSave.Visible = false;
            ClearTextBoxes();
            UpdateGrid();
        }

        private void ClearTextBoxes ()
        {
            txtName.Text = "";
            txtParty.Text = "";
        }

        private void UpdateOrSave ()
        {
            if (btnUpdate.Visible)
            {
                btnSave.Visible = true;
                btnUpdate.Visible = false;
            } 
            else
            {
                btnSave.Visible = false;
                btnUpdate.Visible = true;
            }
        }

        private void UpdateGrid()
        {
            dataGridView1.DataSource = votingSystem.GetAll();
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var name = txtName.Text;
            var party = txtParty.Text;

            Candidate candidate = new Candidate();
            candidate.Name = name;
            candidate.Party = party;

            votingSystem.Add(candidate);
            UpdateGrid();
            ClearTextBoxes();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            loginForm.Visible = true;
            Close();
        }
    }
}
