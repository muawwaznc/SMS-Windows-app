
namespace business_application
{
    partial class Change_password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Change_password));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_new = new System.Windows.Forms.TextBox();
            this.lbl_Warning = new System.Windows.Forms.Label();
            this.txt_previous = new System.Windows.Forms.TextBox();
            this.lbl_change_password = new System.Windows.Forms.Label();
            this.btn_Change = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.lbl_previous_password = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.lbl_new_password = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_change_username = new System.Windows.Forms.Button();
            this.btn_change_password = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txt_new);
            this.groupBox2.Controls.Add(this.lbl_Warning);
            this.groupBox2.Controls.Add(this.txt_previous);
            this.groupBox2.Controls.Add(this.lbl_change_password);
            this.groupBox2.Controls.Add(this.btn_Change);
            this.groupBox2.Controls.Add(this.btn_Reset);
            this.groupBox2.Controls.Add(this.lbl_previous_password);
            this.groupBox2.Controls.Add(this.btn_Back);
            this.groupBox2.Controls.Add(this.lbl_new_password);
            this.groupBox2.Location = new System.Drawing.Point(267, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(495, 248);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            // 
            // txt_new
            // 
            this.txt_new.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txt_new.Location = new System.Drawing.Point(262, 145);
            this.txt_new.Name = "txt_new";
            this.txt_new.Size = new System.Drawing.Size(189, 21);
            this.txt_new.TabIndex = 57;
            // 
            // lbl_Warning
            // 
            this.lbl_Warning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Warning.AutoSize = true;
            this.lbl_Warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Warning.ForeColor = System.Drawing.Color.Red;
            this.lbl_Warning.Location = new System.Drawing.Point(31, 189);
            this.lbl_Warning.Name = "lbl_Warning";
            this.lbl_Warning.Size = new System.Drawing.Size(119, 13);
            this.lbl_Warning.TabIndex = 56;
            this.lbl_Warning.Text = "* Complete all fields";
            this.lbl_Warning.Visible = false;
            // 
            // txt_previous
            // 
            this.txt_previous.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_previous.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txt_previous.Location = new System.Drawing.Point(262, 99);
            this.txt_previous.Name = "txt_previous";
            this.txt_previous.Size = new System.Drawing.Size(189, 21);
            this.txt_previous.TabIndex = 54;
            // 
            // lbl_change_password
            // 
            this.lbl_change_password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_change_password.AutoSize = true;
            this.lbl_change_password.BackColor = System.Drawing.Color.Transparent;
            this.lbl_change_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.lbl_change_password.Location = new System.Drawing.Point(95, 16);
            this.lbl_change_password.Name = "lbl_change_password";
            this.lbl_change_password.Size = new System.Drawing.Size(311, 39);
            this.lbl_change_password.TabIndex = 53;
            this.lbl_change_password.Text = "Change Password";
            // 
            // btn_Change
            // 
            this.btn_Change.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Change.Location = new System.Drawing.Point(351, 205);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(100, 35);
            this.btn_Change.TabIndex = 51;
            this.btn_Change.Text = "Change";
            this.btn_Change.UseVisualStyleBackColor = true;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(160, 205);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(100, 35);
            this.btn_Reset.TabIndex = 50;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // lbl_previous_password
            // 
            this.lbl_previous_password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_previous_password.AutoSize = true;
            this.lbl_previous_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_previous_password.Location = new System.Drawing.Point(30, 98);
            this.lbl_previous_password.Name = "lbl_previous_password";
            this.lbl_previous_password.Size = new System.Drawing.Size(208, 22);
            this.lbl_previous_password.TabIndex = 45;
            this.lbl_previous_password.Text = "Enter previous password";
            // 
            // btn_Back
            // 
            this.btn_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(34, 205);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(100, 35);
            this.btn_Back.TabIndex = 44;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // lbl_new_password
            // 
            this.lbl_new_password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_new_password.AutoSize = true;
            this.lbl_new_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_new_password.Location = new System.Drawing.Point(30, 145);
            this.lbl_new_password.Name = "lbl_new_password";
            this.lbl_new_password.Size = new System.Drawing.Size(173, 22);
            this.lbl_new_password.TabIndex = 46;
            this.lbl_new_password.Text = "Enter new password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::business_application.Properties.Resources.setting_icon_x_100;
            this.pictureBox1.Location = new System.Drawing.Point(69, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // btn_change_username
            // 
            this.btn_change_username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_change_username.BackColor = System.Drawing.Color.Red;
            this.btn_change_username.Location = new System.Drawing.Point(28, 185);
            this.btn_change_username.Name = "btn_change_username";
            this.btn_change_username.Size = new System.Drawing.Size(174, 23);
            this.btn_change_username.TabIndex = 9;
            this.btn_change_username.Text = "Change Username";
            this.btn_change_username.UseVisualStyleBackColor = false;
            this.btn_change_username.Click += new System.EventHandler(this.btn_change_username_Click);
            // 
            // btn_change_password
            // 
            this.btn_change_password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_change_password.BackColor = System.Drawing.Color.Red;
            this.btn_change_password.Location = new System.Drawing.Point(28, 227);
            this.btn_change_password.Name = "btn_change_password";
            this.btn_change_password.Size = new System.Drawing.Size(174, 23);
            this.btn_change_password.TabIndex = 7;
            this.btn_change_password.Text = "Change Password";
            this.btn_change_password.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.btn_exit);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btn_change_username);
            this.groupBox1.Controls.Add(this.btn_change_password);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 450);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.BackColor = System.Drawing.Color.Red;
            this.btn_exit.Location = new System.Drawing.Point(28, 396);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(174, 23);
            this.btn_exit.TabIndex = 45;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Change_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::business_application.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Change_password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Society Management System";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_new;
        private System.Windows.Forms.Label lbl_Warning;
        private System.Windows.Forms.TextBox txt_previous;
        private System.Windows.Forms.Label lbl_change_password;
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Label lbl_previous_password;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label lbl_new_password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_change_username;
        private System.Windows.Forms.Button btn_change_password;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_exit;
    }
}