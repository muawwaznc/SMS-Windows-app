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
    public partial class Change_username : Form
    {
        public Change_username()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Head_main_menu new_form = new Head_main_menu();
            this.Hide();
            new_form.StartPosition = this.StartPosition;
            new_form.Show();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Setting new_form = new Setting();
            this.Hide();
            new_form.StartPosition = this.StartPosition;
            new_form.Show();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_new.Text = "";
            txt_previous.Text = "";
            lbl_Warning.Visible = false;
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            if(txt_new.Text == "" || txt_previous.Text == "")
            {
                lbl_Warning.Text = "* Complete all fields";
                lbl_Warning.Visible = true;
            }
            else
            {
                Admin login = Admin_DL.Get_login();
                if(login.Name == txt_previous.Text)
                {
                    string username = txt_new.Text;
                    string password = login.Password;
                    login.Name = username;
                    Admin_DL.Store_file(username, password);
                    MessageBox.Show("Username changed");
                    btn_Back_Click(sender, e);
                }
                else
                {
                    lbl_Warning.Text = "* You entered invalid username";
                    lbl_Warning.Visible = true;
                }
            }
        }

        private void btn_change_password_Click(object sender, EventArgs e)
        {
            Change_password new_form = new Change_password();
            this.Hide();
            new_form.StartPosition = this.StartPosition;
            new_form.Show();
        }
    }
}
