using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using business_application.DL;
using business_application.BL;
using System.Windows.Forms;

namespace business_application
{
    public partial class Approve_candidate : Form
    {
        public Approve_candidate()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Head_main_menu New_form = new Head_main_menu();
            this.Hide();
            New_form.StartPosition = this.StartPosition;
            New_form.Show();
        }

        private void Sorted_candidated_Click(object sender, EventArgs e)
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

        private void Approve_candidate_Load(object sender, EventArgs e)
        {
            Load_approve_candidate_data();
        }

        private void Load_approve_candidate_data()
        {
            Approve_candidate_data.DataSource = Candidate_DL.Get_candidates();            
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Text = "Approve";
            btn.Name = "btn_Approve";
            btn.UseColumnTextForButtonValue = true;
            Approve_candidate_data.Columns.Add(btn);
            Approve_candidate_data.Columns[0].Visible = false;  //Cetagory
            Approve_candidate_data.Columns[5].Visible = false;  //Designation

            Approve_candidate_data.Columns[1].HeaderText = "Name";
            Approve_candidate_data.Columns[2].HeaderText = "Father Name";
            Approve_candidate_data.Columns[3].HeaderText = "Department";
            Approve_candidate_data.Columns[4].HeaderText = "Aggrigate";
            Approve_candidate_data.Columns[6].HeaderText = "Password";
            Approve_candidate_data.Columns[7].HeaderText = "";
            Approve_candidate_data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Approve_candidate_data.ReadOnly = true;
        }

        private void Approve_candidate_cell_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                int row = e.RowIndex;
                List<Muser> list = Candidate_DL.Get_candidates();
                Muser user = list[row];
                Candidate_DL.Approve_candidate(user);
                Muser_DL.Store_into_file();
                Approve_candidate New_form = new Approve_candidate();
                this.Hide();
                New_form.Show();
            }
        }
    }
}
