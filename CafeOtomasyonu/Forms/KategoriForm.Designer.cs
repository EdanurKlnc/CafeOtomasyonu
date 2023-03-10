namespace CafeOtomasyonu.Forms
{
    partial class KategoriForm
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
            btnGuncelle = new Button();
            lstKategori = new ListBox();
            btnKaydet = new Button();
            txtAd = new TextBox();
            lblKategori = new Label();
            SuspendLayout();
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(320, 243);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(87, 75);
            btnGuncelle.TabIndex = 9;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // lstKategori
            // 
            lstKategori.FormattingEnabled = true;
            lstKategori.ItemHeight = 15;
            lstKategori.Location = new Point(424, 21);
            lstKategori.Name = "lstKategori";
            lstKategori.Size = new Size(234, 409);
            lstKategori.TabIndex = 8;
            lstKategori.SelectedIndexChanged += lstKategori_SelectedIndexChanged;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(230, 243);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(84, 75);
            btnKaydet.TabIndex = 7;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(230, 29);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(177, 23);
            txtAd.TabIndex = 6;
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblKategori.Location = new Point(143, 29);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(72, 15);
            lblKategori.TabIndex = 5;
            lblKategori.Text = "Kategoriler";
            // 
            // KategoriForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuncelle);
            Controls.Add(lstKategori);
            Controls.Add(btnKaydet);
            Controls.Add(txtAd);
            Controls.Add(lblKategori);
            Name = "KategoriForm";
            Text = "KategoriForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuncelle;
        private ListBox lstKategori;
        private Button btnKaydet;
        private TextBox txtAd;
        private Label lblKategori;
    }
}