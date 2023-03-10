namespace CafeOtomasyonu.Forms
{
    partial class UrunForm
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
            lblKategori = new Label();
            label1 = new Label();
            cmbKategori = new ComboBox();
            textBox1 = new TextBox();
            label2 = new Label();
            txtFiyat = new TextBox();
            btnKaydet = new Button();
            btnGuncelle = new Button();
            lstUrun = new ListBox();
            SuspendLayout();
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Location = new Point(41, 42);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(70, 15);
            lblKategori.TabIndex = 0;
            lblKategori.Text = "Kategoriler :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 79);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Ürün :";
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(136, 34);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(166, 23);
            cmbKategori.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(136, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(166, 23);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 119);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 3;
            label2.Text = "Fiyat :";
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(136, 118);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(166, 23);
            txtFiyat.TabIndex = 4;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(115, 255);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(92, 45);
            btnKaydet.TabIndex = 5;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(213, 255);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(89, 45);
            btnGuncelle.TabIndex = 5;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // lstUrun
            // 
            lstUrun.FormattingEnabled = true;
            lstUrun.ItemHeight = 15;
            lstUrun.Location = new Point(332, 34);
            lstUrun.Name = "lstUrun";
            lstUrun.Size = new Size(202, 409);
            lstUrun.TabIndex = 6;
            // 
            // UrunForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 512);
            Controls.Add(lstUrun);
            Controls.Add(btnGuncelle);
            Controls.Add(btnKaydet);
            Controls.Add(txtFiyat);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(cmbKategori);
            Controls.Add(label1);
            Controls.Add(lblKategori);
            Name = "UrunForm";
            Text = "UrunForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKategori;
        private Label label1;
        private ComboBox cmbKategori;
        private TextBox textBox1;
        private Label label2;
        private TextBox txtFiyat;
        private Button btnKaydet;
        private Button btnGuncelle;
        private ListBox lstUrun;
    }
}