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
    public partial class Remove_member : Form
    {
        public Remove_member()
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

        private void Remove_member_Load(object sender, EventArgs e)
        {
            Load_members_data();
        }
        private void Load_members_data()
        {
            Members_data.DataSource = Muser_DL.Get_members();

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Text = "Remove";
            btn.Name = "btn_Remove";
            btn.UseColumnTextForButtonValue = true;
            Members_data.Columns.Add(btn);     // Adding Remove button

            Members_data.Columns[0].Visible = false;  //Cetagory
            Members_data.Columns[5].Visible = false;  //Designation
            Members_data.Columns[6].Visible = false;  //Password

            Members_data.Columns[1].HeaderText = "Name";
            Members_data.Columns[2].HeaderText = "Father Name";
            Members_data.Columns[3].HeaderText = "Department";
            Members_data.Columns[4].HeaderText = "Aggrigate";
            Members_data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Members_data.ReadOnly = true;
        }

        private void Remove_member_cell_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                int row = e.RowIndex;
                List<Muser> list = Muser_DL.Get_members();
                Muser user = list[row];
                Muser_DL.Remove_member(user);
                Muser_DL.Store_into_file();
                Remove_member New_form = new Remove_member();
                this.Hide();
                New_form.Show();
            }
        }
    }
}
