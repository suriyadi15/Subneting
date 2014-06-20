namespace Subneting
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ip2 = new System.Windows.Forms.TextBox();
            this.ip3 = new System.Windows.Forms.TextBox();
            this.ip4 = new System.Windows.Forms.TextBox();
            this.ip1 = new System.Windows.Forms.TextBox();
            this.cdir = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.jlh_Subnet = new System.Windows.Forms.TextBox();
            this.hitung = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listHasil = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tutorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(358, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "/";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(223, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = ".";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(312, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = ".";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(267, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = ".";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ip2
            // 
            this.ip2.Location = new System.Drawing.Point(232, 51);
            this.ip2.MaxLength = 3;
            this.ip2.Name = "ip2";
            this.ip2.Size = new System.Drawing.Size(37, 26);
            this.ip2.TabIndex = 2;
            this.ip2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ip2_KeyPress);
            // 
            // ip3
            // 
            this.ip3.Location = new System.Drawing.Point(277, 52);
            this.ip3.MaxLength = 3;
            this.ip3.Name = "ip3";
            this.ip3.Size = new System.Drawing.Size(37, 26);
            this.ip3.TabIndex = 3;
            this.ip3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ip3_KeyPress);
            // 
            // ip4
            // 
            this.ip4.Location = new System.Drawing.Point(322, 53);
            this.ip4.MaxLength = 3;
            this.ip4.Name = "ip4";
            this.ip4.Size = new System.Drawing.Size(37, 26);
            this.ip4.TabIndex = 4;
            this.ip4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ip4_KeyPress);
            // 
            // ip1
            // 
            this.ip1.Location = new System.Drawing.Point(188, 51);
            this.ip1.MaxLength = 3;
            this.ip1.Name = "ip1";
            this.ip1.Size = new System.Drawing.Size(37, 26);
            this.ip1.TabIndex = 1;
            this.ip1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ip1_KeyPress);
            // 
            // cdir
            // 
            this.cdir.Location = new System.Drawing.Point(376, 54);
            this.cdir.MaxLength = 2;
            this.cdir.Name = "cdir";
            this.cdir.Size = new System.Drawing.Size(26, 26);
            this.cdir.TabIndex = 5;
            this.cdir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cdir_KeyPress);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(8, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "Jumlah Subnet";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // jlh_Subnet
            // 
            this.jlh_Subnet.Location = new System.Drawing.Point(188, 92);
            this.jlh_Subnet.MaxLength = 3;
            this.jlh_Subnet.Name = "jlh_Subnet";
            this.jlh_Subnet.Size = new System.Drawing.Size(37, 26);
            this.jlh_Subnet.TabIndex = 6;
            this.jlh_Subnet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.jlh_Subnet_KeyPress);
            // 
            // hitung
            // 
            this.hitung.Location = new System.Drawing.Point(232, 89);
            this.hitung.Name = "hitung";
            this.hitung.Size = new System.Drawing.Size(82, 29);
            this.hitung.TabIndex = 12;
            this.hitung.Text = "Hasil";
            this.hitung.UseVisualStyleBackColor = true;
            this.hitung.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 29);
            this.button1.TabIndex = 13;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // listHasil
            // 
            this.listHasil.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listHasil.FormattingEnabled = true;
            this.listHasil.ItemHeight = 18;
            this.listHasil.Location = new System.Drawing.Point(12, 139);
            this.listHasil.Name = "listHasil";
            this.listHasil.Size = new System.Drawing.Size(390, 310);
            this.listHasil.TabIndex = 14;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(417, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tutorialToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.aboutToolStripMenuItem.Text = "Creadit";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // tutorialToolStripMenuItem
            // 
            this.tutorialToolStripMenuItem.Name = "tutorialToolStripMenuItem";
            this.tutorialToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tutorialToolStripMenuItem.Text = "Tutorial";
            this.tutorialToolStripMenuItem.Click += new System.EventHandler(this.tutorialToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(417, 454);
            this.Controls.Add(this.listHasil);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hitung);
            this.Controls.Add(this.jlh_Subnet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cdir);
            this.Controls.Add(this.ip2);
            this.Controls.Add(this.ip3);
            this.Controls.Add(this.ip4);
            this.Controls.Add(this.ip1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Subneting";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ip2;
        private System.Windows.Forms.TextBox ip3;
        private System.Windows.Forms.TextBox ip4;
        private System.Windows.Forms.TextBox ip1;
        private System.Windows.Forms.TextBox cdir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox jlh_Subnet;
        private System.Windows.Forms.Button hitung;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listHasil;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tutorialToolStripMenuItem;
    }
}

