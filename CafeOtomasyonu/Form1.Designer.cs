namespace CafeOtomasyonu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblKafeIsmi = new Label();
            pcbGif = new PictureBox();
            btnBahce = new Button();
            btnGiris = new Button();
            btnKat1 = new Button();
            btnTeras = new Button();
            btnAnasayfa = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pcbGif).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblKafeIsmi
            // 
            lblKafeIsmi.AutoSize = true;
            lblKafeIsmi.Location = new Point(34, 28);
            lblKafeIsmi.Name = "lblKafeIsmi";
            lblKafeIsmi.Size = new Size(38, 15);
            lblKafeIsmi.TabIndex = 0;
            lblKafeIsmi.Text = "label1";
            // 
            // pcbGif
            // 
            pcbGif.Location = new Point(55, 80);
            pcbGif.Name = "pcbGif";
            pcbGif.Size = new Size(48, 131);
            pcbGif.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbGif.TabIndex = 1;
            pcbGif.TabStop = false;
            // 
            // btnBahce
            // 
            btnBahce.BackColor = Color.Sienna;
            btnBahce.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnBahce.ForeColor = Color.White;
            btnBahce.Location = new Point(3, 3);
            btnBahce.Name = "btnBahce";
            btnBahce.Size = new Size(284, 60);
            btnBahce.TabIndex = 2;
            btnBahce.Text = "Bahçe";
            btnBahce.UseVisualStyleBackColor = false;
            btnBahce.Click += button1_Click;
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.Sienna;
            btnGiris.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnGiris.ForeColor = Color.White;
            btnGiris.Location = new Point(3, 76);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(284, 53);
            btnGiris.TabIndex = 3;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = false;
            // 
            // btnKat1
            // 
            btnKat1.BackColor = Color.Sienna;
            btnKat1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnKat1.ForeColor = Color.White;
            btnKat1.Location = new Point(3, 141);
            btnKat1.Name = "btnKat1";
            btnKat1.Size = new Size(284, 53);
            btnKat1.TabIndex = 4;
            btnKat1.Text = "Kat 1";
            btnKat1.UseVisualStyleBackColor = false;
            // 
            // btnTeras
            // 
            btnTeras.BackColor = Color.White;
            btnTeras.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnTeras.ForeColor = Color.Sienna;
            btnTeras.Location = new Point(3, 205);
            btnTeras.Name = "btnTeras";
            btnTeras.Size = new Size(284, 53);
            btnTeras.TabIndex = 5;
            btnTeras.Text = "Teras";
            btnTeras.UseVisualStyleBackColor = false;
            // 
            // btnAnasayfa
            // 
            btnAnasayfa.BackColor = Color.DarkOliveGreen;
            btnAnasayfa.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            btnAnasayfa.ForeColor = Color.White;
            btnAnasayfa.Location = new Point(3, 460);
            btnAnasayfa.Name = "btnAnasayfa";
            btnAnasayfa.Size = new Size(284, 53);
            btnAnasayfa.TabIndex = 6;
            btnAnasayfa.Text = "Anasayfa";
            btnAnasayfa.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.SaddleBrown;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(btnTeras, 0, 3);
            tableLayoutPanel1.Controls.Add(btnGiris, 0, 1);
            tableLayoutPanel1.Controls.Add(btnBahce, 0, 0);
            tableLayoutPanel1.Controls.Add(btnKat1, 0, 2);
            tableLayoutPanel1.Controls.Add(btnAnasayfa, 0, 4);
            tableLayoutPanel1.Location = new Point(476, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.9722223F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.3518515F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.08776F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 55.6582F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanel1.Size = new Size(290, 517);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 531);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pcbGif);
            Controls.Add(lblKafeIsmi);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pcbGif).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKafeIsmi;
        private PictureBox pcbGif;
        private Button btnBahce;
        private Button btnGiris;
        private Button btnKat1;
        private Button btnTeras;
        private Button btnAnasayfa;
        private TableLayoutPanel tableLayoutPanel1;
    }
}