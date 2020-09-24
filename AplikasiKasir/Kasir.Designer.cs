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
            this.lNamaKasir = new System.Windows.Forms.Label();
            this.pAtas = new System.Windows.Forms.Panel();
            this.pChildAtas = new System.Windows.Forms.Panel();
            this.lHarga = new System.Windows.Forms.Label();
            this.lTotal = new System.Windows.Forms.Label();
            this.lInvoice = new System.Windows.Forms.Label();
            this.pBawah = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pKanan.SuspendLayout();
            this.pAtas.SuspendLayout();
            this.pChildAtas.SuspendLayout();
            this.pBawah.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pKanan
            // 
            this.pKanan.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pKanan.Controls.Add(this.lNamaKasir);
            this.pKanan.Dock = System.Windows.Forms.DockStyle.Right;
            this.pKanan.Location = new System.Drawing.Point(759, 0);
            this.pKanan.Name = "pKanan";
            this.pKanan.Size = new System.Drawing.Size(425, 561);
            this.pKanan.TabIndex = 0;
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
            this.pBawah.Size = new System.Drawing.Size(759, 361);
            this.pBawah.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(30, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(699, 301);
            this.dataGridView1.TabIndex = 0;
            // 
            // Kasir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.pBawah);
            this.Controls.Add(this.pAtas);
            this.Controls.Add(this.pKanan);
            this.Name = "Kasir";
            this.Text = "Kasir";
            this.pKanan.ResumeLayout(false);
            this.pAtas.ResumeLayout(false);
            this.pChildAtas.ResumeLayout(false);
            this.pBawah.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
    }
}