using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using business_application.DL;
using business_application.BL;

namespace business_application
{
    public partial class Society_profile : Form
    {
        public Society_profile()
        {
            InitializeComponent();
        }

        private void Society_profile_Load(object sender, EventArgs e)
        {
            Society_profile_data.DataSource = Head_DL.Get_heads();
            Society_profile_data.Columns[0].Visible = false;
            Society_profile_data.Columns[2].Visible = false;
            Society_profile_data.Columns[3].Visible = false;
            Society_profile_data.Columns[4].Visible = false;
            Society_profile_data.Columns[5].Width = 365;
            Society_profile_data.Columns[6].Visible = false;
            Society_profile_data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Society_profile_data.ReadOnly = true;
        }

        private void btn_Join_society_Click(object sender, EventArgs e)
        {
            Join_society New_form = new Join_society();
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

        private void btn_Alumni_of_society_Click(object sender, EventArgs e)
        {
            Alumni_of_society New_form = new Alumni_of_society();
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
