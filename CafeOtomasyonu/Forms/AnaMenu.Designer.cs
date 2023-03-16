﻿namespace CafeOtomasyonu.Forms
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
            tableLayoutPanel2 = new TableLayoutPanel();
            tblAna.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
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
            tblAna.Controls.Add(tableLayoutPanel2, 2, 0);
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
            flpKatBilgisi.Dock = DockStyle.Fill;
            flpKatBilgisi.Location = new Point(3, 3);
            flpKatBilgisi.Name = "flpKatBilgisi";
            flpKatBilgisi.Size = new Size(171, 480);
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
            flpMasalar.Dock = DockStyle.Fill;
            flpMasalar.Location = new Point(3, 3);
            flpMasalar.Name = "flpMasalar";
            flpMasalar.Size = new Size(404, 186);
            flpMasalar.TabIndex = 0;
            // 
            // flpKategoriler
            // 
            flpKategoriler.Dock = DockStyle.Fill;
            flpKategoriler.Location = new Point(3, 195);
            flpKategoriler.Name = "flpKategoriler";
            flpKategoriler.Size = new Size(404, 90);
            flpKategoriler.TabIndex = 1;
            // 
            // flpUrunler
            // 
            flpUrunler.Dock = DockStyle.Fill;
            flpUrunler.Location = new Point(3, 291);
            flpUrunler.Name = "flpUrunler";
            flpUrunler.Size = new Size(404, 186);
            flpUrunler.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(596, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.Size = new Size(144, 480);
            tableLayoutPanel2.TabIndex = 2;
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
    }
}