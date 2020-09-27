namespace AplikasiKasir
{
    partial class Admin
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
            this.pMenu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pStat = new System.Windows.Forms.Panel();
            this.pChild = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.pMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMenu
            // 
            this.pMenu.Controls.Add(this.button2);
            this.pMenu.Controls.Add(this.button1);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pMenu.Location = new System.Drawing.Point(0, 0);
            this.pMenu.Name = "pMenu";
            this.pMenu.Padding = new System.Windows.Forms.Padding(15);
            this.pMenu.Size = new System.Drawing.Size(884, 100);
            this.pMenu.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Location = new System.Drawing.Point(15, 15);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.button1.Size = new System.Drawing.Size(70, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kasir\r\n( F1 )";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pStat
            // 
            this.pStat.Dock = System.Windows.Forms.DockStyle.Right;
            this.pStat.Location = new System.Drawing.Point(884, 0);
            this.pStat.Name = "pStat";
            this.pStat.Size = new System.Drawing.Size(300, 561);
            this.pStat.TabIndex = 2;
            // 
            // pChild
            // 
            this.pChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pChild.Location = new System.Drawing.Point(0, 100);
            this.pChild.Name = "pChild";
            this.pChild.Size = new System.Drawing.Size(884, 461);
            this.pChild.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(100, 15);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.button2.Size = new System.Drawing.Size(70, 70);
            this.button2.TabIndex = 1;
            this.button2.Text = "Data User\r\n( F2 )";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.pChild);
            this.Controls.Add(this.pMenu);
            this.Controls.Add(this.pStat);
            this.Name = "Admin";
            this.Text = "Admin";
            this.pMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pStat;
        private System.Windows.Forms.Panel pChild;
        private System.Windows.Forms.Button button2;
    }
}