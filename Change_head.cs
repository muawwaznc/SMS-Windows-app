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
    public partial class Change_head : Form
    {
        public Change_head()
        {
            InitializeComponent();
        }

        private void Change_head_Load(object sender, EventArgs e)
        {
            Load_designations();
            Load_members();
        }

        private void Load_designations()
        {
            List<Muser> heads = Head_DL.Get_heads();
            List<string> designations = Head_DL.Get_designations(heads);
            foreach (string a in designations)
            {
                cbox_Designations.Items.Add(a);
            }
        }

        private void Load_members()
        {
            List<Muser> users = Muser_DL.Get_members();
            List<string> names = Muser_DL.Get_members_name(users);
            foreach (string a in names)
            {
                txt_name.Items.Add(a);
            }
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

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Head_main_menu New_form = new Head_main_menu();
            this.Hide();
            New_form.StartPosition = this.StartPosition;
            New_form.Show();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            cbox_Designations.Text = "";
            txt_name.Text = "";
            lbl_Warning.Visible = false;
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            if(cbox_Designations.Text == "" || txt_name.Text == "")
            {
                lbl_Warning.Visible = true;
            }
            else
            {
                Muser a = Head_DL.Remove_previous_head(cbox_Designations.Text);
                Muser_DL.Remove_member(a);    //   Add the memebr as head in list and delete its previous member object

                Muser b = Head_DL.Add_new_head(txt_name.Text, cbox_Designations.Text);
                Muser_DL.Remove_member(b);   //   Add the new head in list and delete its previous head object

                Muser_DL.Store_into_file();

                MessageBox.Show(txt_name.Text + " is now a \n" + cbox_Designations.Text);
                btn_Reset_Click(sender, e);
            }
        }
    }
}
