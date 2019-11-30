namespace HikingPlus
{
    partial class Form1
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
            this.NewHike_Btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Reload_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // NewHike_Btn
            // 
            this.NewHike_Btn.Location = new System.Drawing.Point(74, 155);
            this.NewHike_Btn.Name = "NewHike_Btn";
            this.NewHike_Btn.Size = new System.Drawing.Size(156, 43);
            this.NewHike_Btn.TabIndex = 0;
            this.NewHike_Btn.Text = "New Hike";
            this.NewHike_Btn.UseVisualStyleBackColor = true;
            this.NewHike_Btn.Click += new System.EventHandler(this.NewHike_Btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(74, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(491, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // Reload_btn
            // 
            this.Reload_btn.Location = new System.Drawing.Point(253, 157);
            this.Reload_btn.Name = "Reload_btn";
            this.Reload_btn.Size = new System.Drawing.Size(173, 40);
            this.Reload_btn.TabIndex = 2;
            this.Reload_btn.Text = "Reload";
            this.Reload_btn.UseVisualStyleBackColor = true;
            this.Reload_btn.Click += new System.EventHandler(this.Reload_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Reload_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.NewHike_Btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewHike_Btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Reload_btn;
    }
}

