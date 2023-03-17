namespace CafeOtomasyonu.Forms
{
    partial class AnaMenu
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
            tblAna = new TableLayoutPanel();
            flpKatBilgisi = new FlowLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            flpMasalar = new FlowLayoutPanel();
            flpKategoriler = new FlowLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            flpUrunler = new FlowLayoutPanel();
            tblSiparis = new TableLayoutPanel();
            label1 = new Label();
            tblAna.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flpKategoriler.SuspendLayout();
            tblSiparis.SuspendLayout();
            SuspendLayout();
            // 
            // tblAna
            // 
            tblAna.ColumnCount = 3;
            tblAna.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.8335438F));
            tblAna.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.32382F));
            tblAna.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.8562012F));
            tblAna.Controls.Add(flpKatBilgisi, 0, 0);
            tblAna.Controls.Add(tableLayoutPanel1, 1, 0);
            tblAna.Controls.Add(tblSiparis, 2, 0);
            tblAna.Dock = DockStyle.Fill;
            tblAna.Location = new Point(0, 0);
            tblAna.Name = "tblAna";
            tblAna.RowCount = 1;
            tblAna.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblAna.Size = new Size(911, 486);
            tblAna.TabIndex = 0;
            // 
            // flpKatBilgisi
            // 
            flpKatBilgisi.BackColor = SystemColors.ActiveBorder;
            flpKatBilgisi.Dock = DockStyle.Left;
            flpKatBilgisi.Location = new Point(3, 3);
            flpKatBilgisi.Name = "flpKatBilgisi";
            flpKatBilgisi.Size = new Size(211, 480);
            flpKatBilgisi.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(flpMasalar, 0, 0);
            tableLayoutPanel1.Controls.Add(flpKategoriler, 0, 1);
            tableLayoutPanel1.Controls.Add(flpUrunler, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(220, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.Size = new Size(497, 480);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // flpMasalar
            // 
            flpMasalar.AutoScroll = true;
            flpMasalar.BackColor = Color.FromArgb(255, 192, 192);
            flpMasalar.Dock = DockStyle.Top;
            flpMasalar.Location = new Point(3, 3);
            flpMasalar.Name = "flpMasalar";
            flpMasalar.Size = new Size(491, 186);
            flpMasalar.TabIndex = 0;
            // 
            // flpKategoriler
            // 
            flpKategoriler.BackColor = Color.FromArgb(192, 255, 192);
            flpKategoriler.Controls.Add(tableLayoutPanel2);
            flpKategoriler.Dock = DockStyle.Fill;
            flpKategoriler.Location = new Point(3, 195);
            flpKategoriler.Name = "flpKategoriler";
            flpKategoriler.Size = new Size(491, 90);
            flpKategoriler.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(8, 8);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // flpUrunler
            // 
            flpUrunler.BackColor = Color.White;
            flpUrunler.Dock = DockStyle.Bottom;
            flpUrunler.Location = new Point(3, 291);
            flpUrunler.Name = "flpUrunler";
            flpUrunler.Size = new Size(491, 186);
            flpUrunler.TabIndex = 2;
            // 
            // tblSiparis
            // 
            tblSiparis.ColumnCount = 1;
            tblSiparis.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblSiparis.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblSiparis.Controls.Add(label1, 0, 0);
            tblSiparis.Location = new Point(723, 3);
            tblSiparis.Name = "tblSiparis";
            tblSiparis.RowCount = 1;
            tblSiparis.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblSiparis.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblSiparis.Size = new Size(185, 166);
            tblSiparis.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(154, 17);
            label1.TabIndex = 0;
            label1.Text = "Sipariş Verilen Ürünler :";
            // 
            // AnaMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(911, 486);
            Controls.Add(tblAna);
            Name = "AnaMenu";
            Text = "AnaMenu";
            Load += AnaMenu_Load;
            tblAna.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            flpKategoriler.ResumeLayout(false);
            tblSiparis.ResumeLayout(false);
            tblSiparis.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblAna;
        private FlowLayoutPanel flpKatBilgisi;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flpMasalar;
        private FlowLayoutPanel flpKategoriler;
        private FlowLayoutPanel flpUrunler;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private TableLayoutPanel tblSiparis;
    }
}