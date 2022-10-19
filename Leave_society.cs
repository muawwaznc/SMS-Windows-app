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
    public partial class Leave_society : Form
    {
        public Leave_society()
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

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Candidate_main_menu New_form = new Candidate_main_menu();
            this.Hide();
            New_form.StartPosition = this.StartPosition;
            New_form.Show();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_name.Text = "";
            txt_password.Text = "";
            lbl_warning.Visible = false;
        }

        private void btn_Leave_Click(object sender, EventArgs e)
        {
            if(txt_name.Text == "" || txt_password.Text == "")
            {
                lbl_warning.Visible = true;
            }
            else
            {
                bool is_leave = Candidate_DL.Leave_society(txt_name.Text, txt_password.Text);
                if (is_leave)
                {
                    MessageBox.Show(txt_name + " Left");
                    btn_Reset_Click(sender, e);
                }
                else
                {
                    lbl_warning.Text = "* You entered invalid username or password";
                }
            }
        }
    }
}
