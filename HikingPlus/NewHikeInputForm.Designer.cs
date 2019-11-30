namespace HikingPlus
{
    partial class NewHikeInputForm
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
            this.components = new System.ComponentModel.Container();
            this.Miles_txtbx = new System.Windows.Forms.TextBox();
            this.Hours_txtbx = new System.Windows.Forms.TextBox();
            this.Name_txtbx = new System.Windows.Forms.TextBox();
            this.Miles_toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Miles_lbl = new System.Windows.Forms.Label();
            this.Hours_lbl = new System.Windows.Forms.Label();
            this.Name_lbl = new System.Windows.Forms.Label();
            this.Difficulty_trackBar = new System.Windows.Forms.TrackBar();
            this.Difficulty_lbl = new System.Windows.Forms.Label();
            this.date_lbl = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Submit_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Difficulty_trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // Miles_txtbx
            // 
            this.Miles_txtbx.Location = new System.Drawing.Point(81, 69);
            this.Miles_txtbx.Name = "Miles_txtbx";
            this.Miles_txtbx.Size = new System.Drawing.Size(211, 20);
            this.Miles_txtbx.TabIndex = 0;
            // 
            // Hours_txtbx
            // 
            this.Hours_txtbx.Location = new System.Drawing.Point(81, 111);
            this.Hours_txtbx.Name = "Hours_txtbx";
            this.Hours_txtbx.Size = new System.Drawing.Size(211, 20);
            this.Hours_txtbx.TabIndex = 1;
            // 
            // Name_txtbx
            // 
            this.Name_txtbx.Location = new System.Drawing.Point(81, 152);
            this.Name_txtbx.Name = "Name_txtbx";
            this.Name_txtbx.Size = new System.Drawing.Size(211, 20);
            this.Name_txtbx.TabIndex = 2;
            // 
            // Miles_toolTip
            // 
            this.Miles_toolTip.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // Miles_lbl
            // 
            this.Miles_lbl.AutoSize = true;
            this.Miles_lbl.Location = new System.Drawing.Point(12, 69);
            this.Miles_lbl.Name = "Miles_lbl";
            this.Miles_lbl.Size = new System.Drawing.Size(34, 13);
            this.Miles_lbl.TabIndex = 3;
            this.Miles_lbl.Text = "Miles:";
            // 
            // Hours_lbl
            // 
            this.Hours_lbl.AutoSize = true;
            this.Hours_lbl.Location = new System.Drawing.Point(13, 111);
            this.Hours_lbl.Name = "Hours_lbl";
            this.Hours_lbl.Size = new System.Drawing.Size(38, 13);
            this.Hours_lbl.TabIndex = 4;
            this.Hours_lbl.Text = "Hours:";
            // 
            // Name_lbl
            // 
            this.Name_lbl.AutoSize = true;
            this.Name_lbl.Location = new System.Drawing.Point(13, 152);
            this.Name_lbl.Name = "Name_lbl";
            this.Name_lbl.Size = new System.Drawing.Size(38, 13);
            this.Name_lbl.TabIndex = 5;
            this.Name_lbl.Text = "Name:";
            // 
            // Difficulty_trackBar
            // 
            this.Difficulty_trackBar.Location = new System.Drawing.Point(91, 246);
            this.Difficulty_trackBar.Minimum = 1;
            this.Difficulty_trackBar.Name = "Difficulty_trackBar";
            this.Difficulty_trackBar.Size = new System.Drawing.Size(145, 45);
            this.Difficulty_trackBar.TabIndex = 6;
            this.Difficulty_trackBar.Value = 1;
            // 
            // Difficulty_lbl
            // 
            this.Difficulty_lbl.AutoSize = true;
            this.Difficulty_lbl.Location = new System.Drawing.Point(12, 246);
            this.Difficulty_lbl.Name = "Difficulty_lbl";
            this.Difficulty_lbl.Size = new System.Drawing.Size(77, 13);
            this.Difficulty_lbl.TabIndex = 7;
            this.Difficulty_lbl.Text = "Difficulty (1-10)";
            // 
            // date_lbl
            // 
            this.date_lbl.AutoSize = true;
            this.date_lbl.Location = new System.Drawing.Point(12, 203);
            this.date_lbl.Name = "date_lbl";
            this.date_lbl.Size = new System.Drawing.Size(30, 13);
            this.date_lbl.TabIndex = 9;
            this.date_lbl.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(81, 203);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(211, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // Submit_btn
            // 
            this.Submit_btn.Location = new System.Drawing.Point(184, 311);
            this.Submit_btn.Name = "Submit_btn";
            this.Submit_btn.Size = new System.Drawing.Size(107, 33);
            this.Submit_btn.TabIndex = 11;
            this.Submit_btn.Text = "Submit";
            this.Submit_btn.UseVisualStyleBackColor = true;
            this.Submit_btn.Click += new System.EventHandler(this.Submit_btn_Click);
            // 
            // NewHikeInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 388);
            this.Controls.Add(this.Submit_btn);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.date_lbl);
            this.Controls.Add(this.Difficulty_lbl);
            this.Controls.Add(this.Difficulty_trackBar);
            this.Controls.Add(this.Name_lbl);
            this.Controls.Add(this.Hours_lbl);
            this.Controls.Add(this.Miles_lbl);
            this.Controls.Add(this.Name_txtbx);
            this.Controls.Add(this.Hours_txtbx);
            this.Controls.Add(this.Miles_txtbx);
            this.Name = "NewHikeInputForm";
            this.Text = "NewHikeInputForm";
            ((System.ComponentModel.ISupportInitialize)(this.Difficulty_trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Miles_txtbx;
        private System.Windows.Forms.TextBox Hours_txtbx;
        private System.Windows.Forms.TextBox Name_txtbx;
        private System.Windows.Forms.ToolTip Miles_toolTip;
        private System.Windows.Forms.Label Miles_lbl;
        private System.Windows.Forms.Label Hours_lbl;
        private System.Windows.Forms.Label Name_lbl;
        private System.Windows.Forms.TrackBar Difficulty_trackBar;
        private System.Windows.Forms.Label Difficulty_lbl;
        private System.Windows.Forms.Label date_lbl;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Submit_btn;
    }
}