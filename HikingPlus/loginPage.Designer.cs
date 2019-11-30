namespace HikingPlus
{
    partial class loginPage
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
            this.userName_txtbx = new System.Windows.Forms.TextBox();
            this.password_txtbx = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.createuser_btn = new System.Windows.Forms.Button();
            this.userName_lbl = new System.Windows.Forms.Label();
            this.password_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userName_txtbx
            // 
            this.userName_txtbx.Location = new System.Drawing.Point(144, 47);
            this.userName_txtbx.Name = "userName_txtbx";
            this.userName_txtbx.Size = new System.Drawing.Size(155, 20);
            this.userName_txtbx.TabIndex = 0;
            // 
            // password_txtbx
            // 
            this.password_txtbx.Location = new System.Drawing.Point(145, 101);
            this.password_txtbx.Name = "password_txtbx";
            this.password_txtbx.Size = new System.Drawing.Size(153, 20);
            this.password_txtbx.TabIndex = 1;
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(42, 292);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(103, 33);
            this.login_btn.TabIndex = 2;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // createuser_btn
            // 
            this.createuser_btn.Location = new System.Drawing.Point(213, 292);
            this.createuser_btn.Name = "createuser_btn";
            this.createuser_btn.Size = new System.Drawing.Size(103, 32);
            this.createuser_btn.TabIndex = 3;
            this.createuser_btn.Text = "Create User";
            this.createuser_btn.UseVisualStyleBackColor = true;
            this.createuser_btn.Click += new System.EventHandler(this.createuser_btn_Click);
            // 
            // userName_lbl
            // 
            this.userName_lbl.AutoSize = true;
            this.userName_lbl.Location = new System.Drawing.Point(25, 47);
            this.userName_lbl.Name = "userName_lbl";
            this.userName_lbl.Size = new System.Drawing.Size(55, 13);
            this.userName_lbl.TabIndex = 4;
            this.userName_lbl.Text = "Username";
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Location = new System.Drawing.Point(25, 101);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(53, 13);
            this.password_lbl.TabIndex = 5;
            this.password_lbl.Text = "Password";
            // 
            // loginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 343);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.userName_lbl);
            this.Controls.Add(this.createuser_btn);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.password_txtbx);
            this.Controls.Add(this.userName_txtbx);
            this.Name = "loginPage";
            this.Text = "Log In For A Hike";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userName_txtbx;
        private System.Windows.Forms.TextBox password_txtbx;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button createuser_btn;
        private System.Windows.Forms.Label userName_lbl;
        private System.Windows.Forms.Label password_lbl;
    }
}