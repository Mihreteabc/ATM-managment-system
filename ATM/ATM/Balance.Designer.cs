namespace ATM
{
    partial class Balance
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.AccNumberlbl = new System.Windows.Forms.Label();
            this.Balancelbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 88);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(604, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "x";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(68, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "WELCOME TO ETB BANK";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 377);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(631, 24);
            this.panel2.TabIndex = 32;
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button12.Location = new System.Drawing.Point(80, 154);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(203, 39);
            this.button12.TabIndex = 33;
            this.button12.Text = "Account Number";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(80, 229);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 39);
            this.button3.TabIndex = 36;
            this.button3.Text = "Your Balance";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button4.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(238, 334);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(146, 39);
            this.button4.TabIndex = 37;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // AccNumberlbl
            // 
            this.AccNumberlbl.AutoSize = true;
            this.AccNumberlbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AccNumberlbl.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccNumberlbl.ForeColor = System.Drawing.Color.Black;
            this.AccNumberlbl.Location = new System.Drawing.Point(374, 154);
            this.AccNumberlbl.Name = "AccNumberlbl";
            this.AccNumberlbl.Size = new System.Drawing.Size(96, 25);
            this.AccNumberlbl.TabIndex = 38;
            this.AccNumberlbl.Text = "ACC NO";
            this.AccNumberlbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Balancelbl
            // 
            this.Balancelbl.AutoSize = true;
            this.Balancelbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Balancelbl.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Balancelbl.ForeColor = System.Drawing.Color.Black;
            this.Balancelbl.Location = new System.Drawing.Point(374, 229);
            this.Balancelbl.Name = "Balancelbl";
            this.Balancelbl.Size = new System.Drawing.Size(149, 25);
            this.Balancelbl.TabIndex = 39;
            this.Balancelbl.Text = "Balance In Br";
            this.Balancelbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 401);
            this.Controls.Add(this.Balancelbl);
            this.Controls.Add(this.AccNumberlbl);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Balance";
            this.Load += new System.EventHandler(this.Balance_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button button12;
        private Button button3;
        private Button button4;
        private Label label5;
        private Label AccNumberlbl;
        private Label Balancelbl;
    }
}