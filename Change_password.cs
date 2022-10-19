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
    public partial class Change_password : Form
    {
        public Change_password()
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
            if (txt_new.Text == "" || txt_previous.Text == "")
            {
                lbl_Warning.Text = "* Complete all fields";
                lbl_Warning.Visible = true;
            }
            else
            {
                Admin login = Admin_DL.Get_login();
                if (login.Password == txt_previous.Text)
                {
                    string username = login.Name;
                    string password = txt_new.Text;
                    login.Password = password;
                    Admin_DL.Store_file(username, password);
                    MessageBox.Show("Password changed");
                    btn_Back_Click(sender, e);
                }
                else
                {
                    lbl_Warning.Text = "* You entered invalid username";
                    lbl_Warning.Visible = true;
                }
            }
        }

        private void btn_change_username_Click(object sender, EventArgs e)
        {
            Change_username new_form = new Change_username();
            this.Hide();
            new_form.StartPosition = this.StartPosition;
            new_form.Show();
        }
    }
}
