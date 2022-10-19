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
    public partial class Head_main_menu : Form
    {
        public Head_main_menu()
        {
            InitializeComponent();
        }

        private void btn_approve_candidate_Click(object sender, EventArgs e)
        {
            Approve_candidate New_form = new Approve_candidate();
            this.Hide();
            New_form.StartPosition = this.StartPosition;
            New_form.Show();
        }

        private void btn_sorted_candidate_Click(object sender, EventArgs e)
        {
            Sorted_candidate New_form = new Sorted_candidate();
            this.Hide();
            New_form.StartPosition = this.StartPosition;
            New_form.Show();
        }

        private void btn_list_of_members_Click(object sender, EventArgs e)
        {
            Add_new_headship New_form = new Add_new_headship();
            this.Hide();
            New_form.StartPosition = this.StartPosition;
            New_form.Show();
        }

        private void btn_Remove_member_Click(object sender, EventArgs e)
        {
            Remove_member New_form = new Remove_member();
            this.Hide();
            New_form.StartPosition = this.StartPosition;
            New_form.Show();
        }

        private void btn_list_heads_Click(object sender, EventArgs e)
        {
            List_of_heads New_form = new List_of_heads();
            this.Hide();
            New_form.StartPosition = this.StartPosition;
            New_form.Show();
        }

        private void btn_change_head_Click(object sender, EventArgs e)
        {
            Change_head New_form = new Change_head();
            this.Hide();
            New_form.StartPosition = this.StartPosition;
            New_form.Show();
        }

        private void Lbl_welcome_text()
        {
            List<Muser> list = Head_DL.Get_heads();
            string line = "Welcome back ";
            line = line + list[0].Name;
            lbl_welcome_back.Text = line;
        }

        private void Head_main_menu_Load(object sender, EventArgs e)
        {
            Lbl_welcome_text();
        }

        private void Logout_pic_Click(object sender, EventArgs e)
        {
            Signin New_form = new Signin();
            this.Hide();
            New_form.StartPosition = this.StartPosition;
            New_form.Show();
        }

        private void Menu1_pic_Click(object sender, EventArgs e)
        {
            box_menu.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            box_menu.Visible = false;
        }

        private void setting_pic_Click(object sender, EventArgs e)
        {
            Setting New_form = new Setting();
            this.Hide();
            New_form.StartPosition = this.StartPosition;
            New_form.Show();
        }
    }
}
