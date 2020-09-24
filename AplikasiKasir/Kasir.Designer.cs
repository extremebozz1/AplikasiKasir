namespace AplikasiKasir
{
    partial class Kasir
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
            this.pKanan = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lNamaKasir = new System.Windows.Forms.Label();
            this.pAtas = new System.Windows.Forms.Panel();
            this.pChildAtas = new System.Windows.Forms.Panel();
            this.lHarga = new System.Windows.Forms.Label();
            this.lTotal = new System.Windows.Forms.Label();
            this.lInvoice = new System.Windows.Forms.Label();
            this.pBawah = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.pMenu = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.pKanan.SuspendLayout();
            this.pAtas.SuspendLayout();
            this.pChildAtas.SuspendLayout();
            this.pBawah.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // pKanan
            // 
            this.pKanan.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pKanan.Controls.Add(this.numericUpDown2);
            this.pKanan.Controls.Add(this.numericUpDown1);
            this.pKanan.Controls.Add(this.button3);
            this.pKanan.Controls.Add(this.textBox1);
            this.pKanan.Controls.Add(this.label3);
            this.pKanan.Controls.Add(this.label2);
            this.pKanan.Controls.Add(this.label1);
            this.pKanan.Controls.Add(this.lNamaKasir);
            this.pKanan.Dock = System.Windows.Forms.DockStyle.Right;
            this.pKanan.Location = new System.Drawing.Point(759, 0);
            this.pKanan.Name = "pKanan";
            this.pKanan.Size = new System.Drawing.Size(425, 491);
            this.pKanan.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(95, 396);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(240, 50);
            this.button3.TabIndex = 4;
            this.button3.Text = "Tambah";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(45, 155);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(343, 32);
            this.textBox1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Diskon ( % )";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Qty";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Barcode / Kode";
            // 
            // lNamaKasir
            // 
            this.lNamaKasir.Dock = System.Windows.Forms.DockStyle.Top;
            this.lNamaKasir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNamaKasir.Location = new System.Drawing.Point(0, 0);
            this.lNamaKasir.Name = "lNamaKasir";
            this.lNamaKasir.Padding = new System.Windows.Forms.Padding(35, 35, 0, 0);
            this.lNamaKasir.Size = new System.Drawing.Size(425, 70);
            this.lNamaKasir.TabIndex = 0;
            this.lNamaKasir.Text = "label1";
            // 
            // pAtas
            // 
            this.pAtas.BackColor = System.Drawing.Color.White;
            this.pAtas.Controls.Add(this.pChildAtas);
            this.pAtas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pAtas.Location = new System.Drawing.Point(0, 0);
            this.pAtas.Name = "pAtas";
            this.pAtas.Padding = new System.Windows.Forms.Padding(30);
            this.pAtas.Size = new System.Drawing.Size(759, 200);
            this.pAtas.TabIndex = 1;
            // 
            // pChildAtas
            // 
            this.pChildAtas.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pChildAtas.Controls.Add(this.lHarga);
            this.pChildAtas.Controls.Add(this.lTotal);
            this.pChildAtas.Controls.Add(this.lInvoice);
            this.pChildAtas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pChildAtas.Location = new System.Drawing.Point(30, 30);
            this.pChildAtas.Name = "pChildAtas";
            this.pChildAtas.Size = new System.Drawing.Size(699, 140);
            this.pChildAtas.TabIndex = 5;
            // 
            // lHarga
            // 
            this.lHarga.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHarga.Location = new System.Drawing.Point(0, 70);
            this.lHarga.Name = "lHarga";
            this.lHarga.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lHarga.Size = new System.Drawing.Size(699, 70);
            this.lHarga.TabIndex = 2;
            this.lHarga.Text = "0";
            this.lHarga.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lTotal
            // 
            this.lTotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.lTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTotal.Location = new System.Drawing.Point(0, 40);
            this.lTotal.Name = "lTotal";
            this.lTotal.Padding = new System.Windows.Forms.Padding(30, 10, 0, 0);
            this.lTotal.Size = new System.Drawing.Size(699, 30);
            this.lTotal.TabIndex = 3;
            this.lTotal.Text = "Total";
            this.lTotal.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lInvoice
            // 
            this.lInvoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.lInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lInvoice.Location = new System.Drawing.Point(0, 0);
            this.lInvoice.Margin = new System.Windows.Forms.Padding(30, 10, 0, 0);
            this.lInvoice.Name = "lInvoice";
            this.lInvoice.Padding = new System.Windows.Forms.Padding(30, 15, 0, 0);
            this.lInvoice.Size = new System.Drawing.Size(699, 40);
            this.lInvoice.TabIndex = 4;
            this.lInvoice.Text = "Invoice";
            // 
            // pBawah
            // 
            this.pBawah.BackColor = System.Drawing.Color.White;
            this.pBawah.Controls.Add(this.dataGridView1);
            this.pBawah.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBawah.Location = new System.Drawing.Point(0, 200);
            this.pBawah.Name = "pBawah";
            this.pBawah.Padding = new System.Windows.Forms.Padding(30);
            this.pBawah.Size = new System.Drawing.Size(759, 291);
            this.pBawah.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(30, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(699, 231);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.keyDown);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Kode Produk";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nama Produk";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Harga";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Qty";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Diskon";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Total";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(1094, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Logout\n( F12 )";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pMenu
            // 
            this.pMenu.Controls.Add(this.button2);
            this.pMenu.Controls.Add(this.button1);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pMenu.Location = new System.Drawing.Point(0, 491);
            this.pMenu.Name = "pMenu";
            this.pMenu.Padding = new System.Windows.Forms.Padding(10);
            this.pMenu.Size = new System.Drawing.Size(1184, 70);
            this.pMenu.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(10, 10);
            this.button2.Margin = new System.Windows.Forms.Padding(10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 50);
            this.button2.TabIndex = 7;
            this.button2.Text = "Pembayaran\n( F2 )";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(45, 245);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(343, 32);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.Location = new System.Drawing.Point(45, 335);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(343, 32);
            this.numericUpDown2.TabIndex = 3;
            // 
            // Kasir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.pBawah);
            this.Controls.Add(this.pAtas);
            this.Controls.Add(this.pKanan);
            this.Controls.Add(this.pMenu);
            this.Name = "Kasir";
            this.Text = "Kasir";
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.keyDown);
            this.pKanan.ResumeLayout(false);
            this.pKanan.PerformLayout();
            this.pAtas.ResumeLayout(false);
            this.pChildAtas.ResumeLayout(false);
            this.pBawah.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pKanan;
        private System.Windows.Forms.Panel pAtas;
        private System.Windows.Forms.Label lNamaKasir;
        private System.Windows.Forms.Panel pBawah;
        private System.Windows.Forms.Label lHarga;
        private System.Windows.Forms.Panel pChildAtas;
        private System.Windows.Forms.Label lInvoice;
        private System.Windows.Forms.Label lTotal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
    }
}