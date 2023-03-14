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
            flpKatlar = new FlowLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            flpMasalar = new FlowLayoutPanel();
            flwKategoriler = new FlowLayoutPanel();
            flpUrunler = new FlowLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tblAna.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tblAna
            // 
            tblAna.ColumnCount = 3;
            tblAna.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblAna.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tblAna.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblAna.Controls.Add(flpKatlar, 0, 0);
            tblAna.Controls.Add(tableLayoutPanel1, 1, 0);
            tblAna.Controls.Add(tableLayoutPanel2, 2, 0);
            tblAna.Dock = DockStyle.Fill;
            tblAna.Location = new Point(0, 0);
            tblAna.Name = "tblAna";
            tblAna.RowCount = 1;
            tblAna.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblAna.Size = new Size(793, 499);
            tblAna.TabIndex = 0;
            // 
            // flpKatlar
            // 
            flpKatlar.Location = new Point(3, 3);
            flpKatlar.Name = "flpKatlar";
            flpKatlar.Size = new Size(152, 493);
            flpKatlar.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(flpMasalar, 0, 0);
            tableLayoutPanel1.Controls.Add(flwKategoriler, 0, 1);
            tableLayoutPanel1.Controls.Add(flpUrunler, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(161, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.Size = new Size(469, 493);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // flpMasalar
            // 
            flpMasalar.Dock = DockStyle.Fill;
            flpMasalar.Location = new Point(3, 3);
            flpMasalar.Name = "flpMasalar";
            flpMasalar.Size = new Size(463, 191);
            flpMasalar.TabIndex = 0;
            // 
            // flwKategoriler
            // 
            flwKategoriler.Dock = DockStyle.Fill;
            flwKategoriler.Location = new Point(3, 200);
            flwKategoriler.Name = "flwKategoriler";
            flwKategoriler.Size = new Size(463, 92);
            flwKategoriler.TabIndex = 1;
            // 
            // flpUrunler
            // 
            flpUrunler.Dock = DockStyle.Fill;
            flpUrunler.Location = new Point(3, 298);
            flpUrunler.Name = "flpUrunler";
            flpUrunler.Size = new Size(463, 192);
            flpUrunler.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(636, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.Size = new Size(154, 493);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // AnaMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(793, 499);
            Controls.Add(tblAna);
            Name = "AnaMenu";
            Text = "AnaMenu";
            tblAna.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblAna;
        private FlowLayoutPanel flpKatlar;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flpMasalar;
        private FlowLayoutPanel flwKategoriler;
        private FlowLayoutPanel flpUrunler;
        private TableLayoutPanel tableLayoutPanel2;
    }
}