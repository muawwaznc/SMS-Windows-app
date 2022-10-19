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
    public partial class Sorted_candidate : Form
    {
        public Sorted_candidate()
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

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Head_main_menu New_form = new Head_main_menu(); 
            this.Hide();
            New_form.StartPosition = this.StartPosition;
            New_form.Show();
        }

        private void Sorted_candidate_Load(object sender, EventArgs e)
        {
            Load_sorted_candidate_data();
        }
        private void Load_sorted_candidate_data()
        {
            Sorted_candidate_data.DataSource = Candidate_DL.Get_candidates();
            Sorted_candidate_data.Columns[0].Visible = false;  //Cetagory
            Sorted_candidate_data.Columns[5].Visible = false;  //Designation

            Sorted_candidate_data.Columns[1].HeaderText = "Name";
            Sorted_candidate_data.Columns[2].HeaderText = "Father Name";
            Sorted_candidate_data.Columns[3].HeaderText = "Department";
            Sorted_candidate_data.Columns[4].HeaderText = "Aggrigate";
            Sorted_candidate_data.Columns[6].HeaderText = "Password";
            Sorted_candidate_data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Sorted_candidate_data.ReadOnly = true;
        }
    }
}
