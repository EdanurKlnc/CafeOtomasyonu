namespace CafeOtomasyonu.Forms
{
    partial class KatBilgisi
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
            txtbxKatBilgi = new TextBox();
            label1 = new Label();
            btnKatUret = new Button();
            label2 = new Label();
            txtMasaSayisi = new TextBox();
            lstKat = new ListBox();
            SuspendLayout();
            // 
            // txtbxKatBilgi
            // 
            txtbxKatBilgi.Location = new Point(168, 34);
            txtbxKatBilgi.Name = "txtbxKatBilgi";
            txtbxKatBilgi.Size = new Size(162, 23);
            txtbxKatBilgi.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(44, 31);
            label1.Name = "label1";
            label1.Size = new Size(117, 19);
            label1.TabIndex = 1;
            label1.Text = "Kat Adı Giriniz :";
            // 
            // btnKatUret
            // 
            btnKatUret.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnKatUret.Location = new Point(168, 178);
            btnKatUret.Name = "btnKatUret";
            btnKatUret.Size = new Size(162, 38);
            btnKatUret.TabIndex = 2;
            btnKatUret.Text = "Kaydet";
            btnKatUret.UseVisualStyleBackColor = true;
            btnKatUret.Click += btnKatUret_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 85);
            label2.Name = "label2";
            label2.Size = new Size(149, 19);
            label2.TabIndex = 5;
            label2.Text = "Masa Sayısı Giriniz :";
            // 
            // txtMasaSayisi
            // 
            txtMasaSayisi.Location = new Point(168, 81);
            txtMasaSayisi.Name = "txtMasaSayisi";
            txtMasaSayisi.Size = new Size(162, 23);
            txtMasaSayisi.TabIndex = 6;
            // 
            // lstKat
            // 
            lstKat.FormattingEnabled = true;
            lstKat.ItemHeight = 15;
            lstKat.Location = new Point(410, 34);
            lstKat.Name = "lstKat";
            lstKat.Size = new Size(181, 184);
            lstKat.TabIndex = 7;
            // 
            // KatBilgisi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 439);
            Controls.Add(lstKat);
            Controls.Add(txtMasaSayisi);
            Controls.Add(label2);
            Controls.Add(btnKatUret);
            Controls.Add(label1);
            Controls.Add(txtbxKatBilgi);
            Name = "KatBilgisi";
            Text = "KatBilgisi";
            Load += KatBilgisi_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbxKatBilgi;
        private Label label1;
        private Button btnKatUret;
        private Label label2;
        private TextBox txtMasaSayisi;
        private ListBox lstKat;
    }
}