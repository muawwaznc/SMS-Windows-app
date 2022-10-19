
namespace business_application
{
    partial class Society_profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Society_profile));
            this.btn_About_society = new System.Windows.Forms.Button();
            this.btn_Join_society = new System.Windows.Forms.Button();
            this.btn_Society_profile = new System.Windows.Forms.Button();
            this.btn_Alumni_of_society = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Leave_society = new System.Windows.Forms.Button();
            this.Society_profile_data = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Society_profile_data)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_About_society
            // 
            this.btn_About_society.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_About_society.BackColor = System.Drawing.Color.Red;
            this.btn_About_society.Location = new System.Drawing.Point(28, 290);
            this.btn_About_society.Name = "btn_About_society";
            this.btn_About_society.Size = new System.Drawing.Size(174, 23);
            this.btn_About_society.TabIndex = 2;
            this.btn_About_society.Text = "About Society";
            this.btn_About_society.UseVisualStyleBackColor = false;
            this.btn_About_society.Click += new System.EventHandler(this.btn_About_society_Click);
            // 
            // btn_Join_society
            // 
            this.btn_Join_society.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Join_society.BackColor = System.Drawing.Color.Red;
            this.btn_Join_society.Location = new System.Drawing.Point(28, 200);
            this.btn_Join_society.Name = "btn_Join_society";
            this.btn_Join_society.Size = new System.Drawing.Size(174, 23);
            this.btn_Join_society.TabIndex = 3;
            this.btn_Join_society.Text = "Join Society";
            this.btn_Join_society.UseVisualStyleBackColor = false;
            this.btn_Join_society.Click += new System.EventHandler(this.btn_Join_society_Click);
            // 
            // btn_Society_profile
            // 
            this.btn_Society_profile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Society_profile.BackColor = System.Drawing.Color.Red;
            this.btn_Society_profile.Location = new System.Drawing.Point(28, 245);
            this.btn_Society_profile.Name = "btn_Society_profile";
            this.btn_Society_profile.Size = new System.Drawing.Size(174, 23);
            this.btn_Society_profile.TabIndex = 1;
            this.btn_Society_profile.Text = "Society profile";
            this.btn_Society_profile.UseVisualStyleBackColor = false;
            // 
            // btn_Alumni_of_society
            // 
            this.btn_Alumni_of_society.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Alumni_of_society.BackColor = System.Drawing.Color.Red;
            this.btn_Alumni_of_society.Location = new System.Drawing.Point(28, 335);
            this.btn_Alumni_of_society.Name = "btn_Alumni_of_society";
            this.btn_Alumni_of_society.Size = new System.Drawing.Size(174, 23);
            this.btn_Alumni_of_society.TabIndex = 6;
            this.btn_Alumni_of_society.Text = "Alumni of Society";
            this.btn_Alumni_of_society.UseVisualStyleBackColor = false;
            this.btn_Alumni_of_society.Click += new System.EventHandler(this.btn_Alumni_of_society_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(265, 387);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(100, 35);
            this.btn_Back.TabIndex = 32;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btn_Alumni_of_society);
            this.groupBox1.Controls.Add(this.btn_Leave_society);
            this.groupBox1.Controls.Add(this.btn_About_society);
            this.groupBox1.Controls.Add(this.btn_Join_society);
            this.groupBox1.Controls.Add(this.btn_Society_profile);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 450);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::business_application.Properties.Resources.Community_White;
            this.pictureBox1.Location = new System.Drawing.Point(69, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Leave_society
            // 
            this.btn_Leave_society.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Leave_society.BackColor = System.Drawing.Color.Red;
            this.btn_Leave_society.Location = new System.Drawing.Point(28, 380);
            this.btn_Leave_society.Name = "btn_Leave_society";
            this.btn_Leave_society.Size = new System.Drawing.Size(174, 23);
            this.btn_Leave_society.TabIndex = 4;
            this.btn_Leave_society.Text = "Leave Society";
            this.btn_Leave_society.UseVisualStyleBackColor = false;
            this.btn_Leave_society.Click += new System.EventHandler(this.btn_Leave_society_Click);
            // 
            // Society_profile_data
            // 
            this.Society_profile_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Society_profile_data.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.Society_profile_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Society_profile_data.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Society_profile_data.Location = new System.Drawing.Point(265, 89);
            this.Society_profile_data.Name = "Society_profile_data";
            this.Society_profile_data.Size = new System.Drawing.Size(507, 292);
            this.Society_profile_data.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 39);
            this.label1.TabIndex = 34;
            this.label1.Text = "Society Profile";
            // 
            // Society_profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::business_application.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Society_profile_data);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Society_profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Society Management System";
            this.Load += new System.EventHandler(this.Society_profile_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Society_profile_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_About_society;
        private System.Windows.Forms.Button btn_Join_society;
        private System.Windows.Forms.Button btn_Society_profile;
        private System.Windows.Forms.Button btn_Alumni_of_society;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Leave_society;
        private System.Windows.Forms.DataGridView Society_profile_data;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}