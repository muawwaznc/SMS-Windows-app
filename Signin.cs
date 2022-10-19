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
    public partial class Signin : Form
    {
        public Signin()
        {
            InitializeComponent();
        }

        private void btn_Signin_Click(object sender, EventArgs e)
        {
            if(txt_username.Text == "" || txt_password.Text == "")
            {
                lbl_Warning.Text = "* Complete all fields";
                lbl_Warning.Visible = true;
            }
            else
            {
                Admin login = Admin_DL.Get_login();
                string name = txt_username.Text;
                string password = txt_password.Text;
                if (name == login.Name && password == login.Password)
                {
                    Head_main_menu New_form = new Head_main_menu();
                    this.Hide();
                    New_form.StartPosition = this.StartPosition;
                    New_form.Show();
                }
                else
                {
                    lbl_Warning.Text = "* You entered an invalid username or password";
                    lbl_Warning.Visible = true;
                }
            }            
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
