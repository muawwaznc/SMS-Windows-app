using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using business_application.BL;
using business_application.DL;

namespace business_application
{
    public partial class Alumni_of_society : Form
    {
        public Alumni_of_society()
        {
            InitializeComponent();
        }

        private void Alumni_of_society_Load(object sender, EventArgs e)
        {
            List<Alumni> alumni = Alumni_DL.Get_list();
            Alumni_data.DataSource = alumni;
            Alumni_data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Alumni_data.ReadOnly = true;
        }

        private void btn_Join_society_Click(object sender, EventArgs e)
        {
            Join_society New_form = new Join_society();
            this.Hide();
            New_form.StartPosition = this.StartPosition;
            New_form.Show();
        }

        private void btn_Society_profile_Click(object sender, EventArgs e)
        {
            Society_profile New_form = new Society_profile();
            this.Hide();
            New_form.StartPosition = this.StartPosition;
            New_form.Show();
        }

        private void btn_About_society_Click(object sender, EventArgs e)
        {
            About_society New_form = new About_society();
            this.Hide();
            New_form.StartPosition = this.StartPosition;
            New_form.Show();
        }

        private void btn_Leave_society_Click(object sender, EventArgs e)
        {
            Leave_society New_form = new Leave_society();
            this.Hide();
            New_form.StartPosition = this.StartPosition;
            New_form.Show();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Candidate_main_menu New_form = new Candidate_main_menu();
            this.Hide();
            New_form.StartPosition = this.StartPosition;
            New_form.Show();
        }
    }
}
