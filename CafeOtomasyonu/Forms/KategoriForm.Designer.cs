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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KategoriForm));
            btnGuncelle = new Button();
            lstKategori = new ListBox();
            btnKaydet = new Button();
            txtAd = new TextBox();
            lblKategori = new Label();
            SuspendLayout();
            // 
            // btnGuncelle
            // 
            btnGuncelle.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuncelle.Location = new Point(199, 121);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(135, 79);
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
            btnKaydet.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnKaydet.Location = new Point(38, 125);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(135, 75);
            btnKaydet.TabIndex = 7;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(157, 30);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(177, 23);
            txtAd.TabIndex = 6;
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblKategori.Location = new Point(38, 29);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(113, 24);
            lblKategori.TabIndex = 5;
            lblKategori.Text = "Kategoriler";
            // 
            // KategoriForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(689, 493);
            Controls.Add(btnGuncelle);
            Controls.Add(lstKategori);
            Controls.Add(btnKaydet);
            Controls.Add(txtAd);
            Controls.Add(lblKategori);
            Name = "KategoriForm";
            Text = "KategoriForm";
            Load += KategoriForm_Load;
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