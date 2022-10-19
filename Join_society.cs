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
    public partial class Join_society : Form
    {
        public Join_society()
        {
            InitializeComponent();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_name.Text = null;
            txt_f_name.Text = null;
            txt_dept.Text = null;
            txt_aggrigate.Text = null;
            txt_password.Text = null;
            lbl_warning.Visible = false;
            lbl_Agrrigate_warning.Visible = false;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Candidate_main_menu New_form = new Candidate_main_menu();
            this.Hide();
            New_form.StartPosition = this.StartPosition;
            New_form.Show();
        }

        private void btn_Join_Click(object sender, EventArgs e)
        {
            if(txt_name.Text == "" || txt_f_name.Text == "" || txt_dept.Text == "" || !(Check_aggrigate_warning()) || txt_password.Text == "")
            {
                lbl_warning.Visible = true; ;
            }
            else
            {
                string name = txt_name.Text;
                string fname = txt_f_name.Text;
                string dept = txt_dept.Text;
                float aggrigate = float.Parse(txt_aggrigate.Text);
                string password = txt_password.Text;
                Candidate candidate = new Candidate("candidate", name, fname, dept, aggrigate, password);
                Muser_DL.Add_into_list(candidate);
                Muser_DL.Add_into_file(candidate);
                btn_Reset_Click(sender, e);
                lbl_warning.Text = "";
            }
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

        private bool Check_aggrigate_warning()
        {
            bool flag;
            try
            {
                float aggrigate = float.Parse(txt_aggrigate.Text);
                flag = true;
            }
            catch
            {
                lbl_Agrrigate_warning.Visible = true;
                flag = false;
            }
            return flag;
        }
    }
}
