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
    public partial class Setting : Form
    {
        public Setting()
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

        private void btn_change_username_Click(object sender, EventArgs e)
        {
            Change_username new_form = new Change_username();
            this.Hide();
            new_form.StartPosition = this.StartPosition;
            new_form.Show();
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
