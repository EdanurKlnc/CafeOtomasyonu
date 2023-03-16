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
            flpUrunler = new FlowLayoutPanel();
            tblHesap = new TableLayoutPanel();
            label1 = new Label();
            tblAna.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tblHesap.SuspendLayout();
            SuspendLayout();
            // 
            // tblAna
            // 
            tblAna.ColumnCount = 3;
            tblAna.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.8335438F));
            tblAna.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.98991F));
            tblAna.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblAna.Controls.Add(flpKatBilgisi, 0, 0);
            tblAna.Controls.Add(tableLayoutPanel1, 1, 0);
            tblAna.Controls.Add(tblHesap, 2, 0);
            tblAna.Dock = DockStyle.Fill;
            tblAna.Location = new Point(0, 0);
            tblAna.Name = "tblAna";
            tblAna.RowCount = 1;
            tblAna.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblAna.Size = new Size(743, 486);
            tblAna.TabIndex = 0;
            // 
            // flpKatBilgisi
            // 
            flpKatBilgisi.BackColor = SystemColors.ActiveBorder;
            flpKatBilgisi.Location = new Point(3, 3);
            flpKatBilgisi.Name = "flpKatBilgisi";
            flpKatBilgisi.Size = new Size(171, 453);
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
            tableLayoutPanel1.Location = new Point(180, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.Size = new Size(410, 480);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // flpMasalar
            // 
            flpMasalar.AutoScroll = true;
            flpMasalar.BackColor = Color.FromArgb(255, 192, 192);
            flpMasalar.Dock = DockStyle.Fill;
            flpMasalar.Location = new Point(3, 3);
            flpMasalar.Name = "flpMasalar";
            flpMasalar.Size = new Size(404, 186);
            flpMasalar.TabIndex = 0;
            // 
            // flpKategoriler
            // 
            flpKategoriler.BackColor = Color.FromArgb(192, 255, 192);
            flpKategoriler.Dock = DockStyle.Fill;
            flpKategoriler.Location = new Point(3, 195);
            flpKategoriler.Name = "flpKategoriler";
            flpKategoriler.Size = new Size(404, 90);
            flpKategoriler.TabIndex = 1;
            // 
            // flpUrunler
            // 
            flpUrunler.BackColor = Color.White;
            flpUrunler.Dock = DockStyle.Fill;
            flpUrunler.Location = new Point(3, 291);
            flpUrunler.Name = "flpUrunler";
            flpUrunler.Size = new Size(404, 186);
            flpUrunler.TabIndex = 2;
            // 
            // tblHesap
            // 
            tblHesap.ColumnCount = 1;
            tblHesap.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblHesap.Controls.Add(label1, 0, 0);
            tblHesap.Dock = DockStyle.Fill;
            tblHesap.Location = new Point(596, 3);
            tblHesap.Name = "tblHesap";
            tblHesap.RowCount = 2;
            tblHesap.RowStyles.Add(new RowStyle(SizeType.Percent, 17.5F));
            tblHesap.RowStyles.Add(new RowStyle(SizeType.Percent, 82.5F));
            tblHesap.Size = new Size(144, 480);
            tblHesap.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 0;
            label1.Text = "Sipariş edilen ürünler :";
            // 
            // AnaMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(743, 486);
            Controls.Add(tblAna);
            Name = "AnaMenu";
            Text = "AnaMenu";
            Load += AnaMenu_Load;
            tblAna.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tblHesap.ResumeLayout(false);
            tblHesap.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblAna;
        private FlowLayoutPanel flpKatBilgisi;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flpMasalar;
        private FlowLayoutPanel flpKategoriler;
        private FlowLayoutPanel flpUrunler;
        private TableLayoutPanel tblHesap;
        private Label label1;
    }
}