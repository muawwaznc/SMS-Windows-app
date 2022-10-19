
namespace business_application
{
    partial class List_of_heads
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(List_of_heads));
            this.btn_Back = new System.Windows.Forms.Button();
            this.Heads_data = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_change_head = new System.Windows.Forms.Button();
            this.btn_Remove_member = new System.Windows.Forms.Button();
            this.btn_list_heads = new System.Windows.Forms.Button();
            this.btn_list_of_members = new System.Windows.Forms.Button();
            this.btn_approve_candidate = new System.Windows.Forms.Button();
            this.btn_sorted_candidate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Heads_data)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(265, 377);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(100, 35);
            this.btn_Back.TabIndex = 41;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // Heads_data
            // 
            this.Heads_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Heads_data.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.Heads_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Heads_data.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Heads_data.Location = new System.Drawing.Point(265, 79);
            this.Heads_data.Name = "Heads_data";
            this.Heads_data.Size = new System.Drawing.Size(507, 292);
            this.Heads_data.TabIndex = 42;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btn_change_head);
            this.groupBox1.Controls.Add(this.btn_Remove_member);
            this.groupBox1.Controls.Add(this.btn_list_heads);
            this.groupBox1.Controls.Add(this.btn_list_of_members);
            this.groupBox1.Controls.Add(this.btn_approve_candidate);
            this.groupBox1.Controls.Add(this.btn_sorted_candidate);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 450);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::business_application.Properties.Resources.Community_White;
            this.pictureBox1.Location = new System.Drawing.Point(69, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // btn_change_head
            // 
            this.btn_change_head.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_change_head.BackColor = System.Drawing.Color.Red;
            this.btn_change_head.Location = new System.Drawing.Point(28, 396);
            this.btn_change_head.Name = "btn_change_head";
            this.btn_change_head.Size = new System.Drawing.Size(174, 23);
            this.btn_change_head.TabIndex = 11;
            this.btn_change_head.Text = "Change Head";
            this.btn_change_head.UseVisualStyleBackColor = false;
            this.btn_change_head.Click += new System.EventHandler(this.btn_change_head_Click);
            // 
            // btn_Remove_member
            // 
            this.btn_Remove_member.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Remove_member.BackColor = System.Drawing.Color.Red;
            this.btn_Remove_member.Location = new System.Drawing.Point(28, 312);
            this.btn_Remove_member.Name = "btn_Remove_member";
            this.btn_Remove_member.Size = new System.Drawing.Size(174, 23);
            this.btn_Remove_member.TabIndex = 12;
            this.btn_Remove_member.Text = "Remove Member";
            this.btn_Remove_member.UseVisualStyleBackColor = false;
            this.btn_Remove_member.Click += new System.EventHandler(this.btn_Remove_member_Click);
            // 
            // btn_list_heads
            // 
            this.btn_list_heads.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_list_heads.BackColor = System.Drawing.Color.Red;
            this.btn_list_heads.Location = new System.Drawing.Point(28, 354);
            this.btn_list_heads.Name = "btn_list_heads";
            this.btn_list_heads.Size = new System.Drawing.Size(174, 23);
            this.btn_list_heads.TabIndex = 10;
            this.btn_list_heads.Text = "List of Heads";
            this.btn_list_heads.UseVisualStyleBackColor = false;
            // 
            // btn_list_of_members
            // 
            this.btn_list_of_members.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_list_of_members.BackColor = System.Drawing.Color.Red;
            this.btn_list_of_members.Location = new System.Drawing.Point(28, 269);
            this.btn_list_of_members.Name = "btn_list_of_members";
            this.btn_list_of_members.Size = new System.Drawing.Size(174, 23);
            this.btn_list_of_members.TabIndex = 8;
            this.btn_list_of_members.Text = "Add New Headship";
            this.btn_list_of_members.UseVisualStyleBackColor = false;
            this.btn_list_of_members.Click += new System.EventHandler(this.btn_list_of_members_Click);
            // 
            // btn_approve_candidate
            // 
            this.btn_approve_candidate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_approve_candidate.BackColor = System.Drawing.Color.Red;
            this.btn_approve_candidate.Location = new System.Drawing.Point(28, 185);
            this.btn_approve_candidate.Name = "btn_approve_candidate";
            this.btn_approve_candidate.Size = new System.Drawing.Size(174, 23);
            this.btn_approve_candidate.TabIndex = 9;
            this.btn_approve_candidate.Text = "Approve Candidate";
            this.btn_approve_candidate.UseVisualStyleBackColor = false;
            this.btn_approve_candidate.Click += new System.EventHandler(this.btn_approve_candidate_Click);
            // 
            // btn_sorted_candidate
            // 
            this.btn_sorted_candidate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sorted_candidate.BackColor = System.Drawing.Color.Red;
            this.btn_sorted_candidate.Location = new System.Drawing.Point(28, 227);
            this.btn_sorted_candidate.Name = "btn_sorted_candidate";
            this.btn_sorted_candidate.Size = new System.Drawing.Size(174, 23);
            this.btn_sorted_candidate.TabIndex = 7;
            this.btn_sorted_candidate.Text = "Sorted Candidate";
            this.btn_sorted_candidate.UseVisualStyleBackColor = false;
            this.btn_sorted_candidate.Click += new System.EventHandler(this.btn_sorted_candidate_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(258, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 39);
            this.label1.TabIndex = 44;
            this.label1.Text = "List of Heads";
            // 
            // List_of_heads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::business_application.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.Heads_data);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "List_of_heads";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Society Management System";
            this.Load += new System.EventHandler(this.List_of_heads_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Heads_data)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.DataGridView Heads_data;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_change_head;
        private System.Windows.Forms.Button btn_Remove_member;
        private System.Windows.Forms.Button btn_list_heads;
        private System.Windows.Forms.Button btn_list_of_members;
        private System.Windows.Forms.Button btn_approve_candidate;
        private System.Windows.Forms.Button btn_sorted_candidate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}