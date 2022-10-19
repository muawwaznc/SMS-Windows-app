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

namespace business_application
{
    public partial class List_of_heads : Form
    {
        public List_of_heads()
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

        private void btn_change_head_Click(object sender, EventArgs e)
        {
            Change_head New_form = new Change_head();
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

        private void List_of_heads_Load(object sender, EventArgs e)
        {
            Load_heads_data();
        }
        private void Load_heads_data()
        {
            Heads_data.DataSource = Head_DL.Get_heads();
            Heads_data.Columns[0].Visible = false;  //Cetagory            
            Heads_data.Columns[6].Visible = false;  //Password

            Heads_data.Columns[1].HeaderText = "Name";
            Heads_data.Columns[2].HeaderText = "Father Name";
            Heads_data.Columns[3].HeaderText = "Department";
            Heads_data.Columns[4].HeaderText = "Aggrigate";
            Heads_data.Columns[5].HeaderText = "Designation";
            Heads_data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
