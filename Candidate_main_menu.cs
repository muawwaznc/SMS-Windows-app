using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace business_application
{
    public partial class Candidate_main_menu : Form
    {
        public Candidate_main_menu()
        {
            InitializeComponent();
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

        private void Signin_icon_Click(object sender, EventArgs e)
        {
            Signin New_form = new Signin();
            this.Hide();
            
            New_form.Show();
            New_form.StartPosition = this.StartPosition;
        }

        private void lbl_Signin_Click(object sender, EventArgs e)
        {
            Signin New_form = new Signin();
            this.Hide();
            New_form.StartPosition = this.StartPosition;
            New_form.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
