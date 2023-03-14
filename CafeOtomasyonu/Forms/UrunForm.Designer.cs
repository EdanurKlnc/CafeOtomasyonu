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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunForm));
            cmsSil = new ContextMenuStrip(components);
            silToolStripMenuItem = new ToolStripMenuItem();
            dosyaAc = new OpenFileDialog();
            dosyaKaydet = new SaveFileDialog();
            lstUrun = new ListBox();
            lblKategori = new Label();
            label1 = new Label();
            cmbKategori = new ComboBox();
            txtAd = new TextBox();
            label2 = new Label();
            txtFiyat = new TextBox();
            btnKaydet = new Button();
            btnGuncelle = new Button();
            label3 = new Label();
            pcFoto = new PictureBox();
            cmsSil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcFoto).BeginInit();
            SuspendLayout();
            // 
            // cmsSil
            // 
            cmsSil.Items.AddRange(new ToolStripItem[] { silToolStripMenuItem });
            cmsSil.Name = "cmsSil";
            cmsSil.Size = new Size(87, 26);
            // 
            // silToolStripMenuItem
            // 
            silToolStripMenuItem.Name = "silToolStripMenuItem";
            silToolStripMenuItem.Size = new Size(86, 22);
            silToolStripMenuItem.Text = "Sil";
            silToolStripMenuItem.Click += silToolStripMenuItem_Click;
            // 
            // dosyaAc
            // 
            dosyaAc.FileName = "dosyaAc";
            // 
            // dosyaKaydet
            // 
            dosyaKaydet.FileName = "dosyaKaydet";
            // 
            // lstUrun
            // 
            lstUrun.ContextMenuStrip = cmsSil;
            lstUrun.FormattingEnabled = true;
            lstUrun.ItemHeight = 15;
            lstUrun.Location = new Point(419, 63);
            lstUrun.Name = "lstUrun";
            lstUrun.Size = new Size(145, 304);
            lstUrun.TabIndex = 6;
            lstUrun.SelectedIndexChanged += lstUrun_SelectedIndexChanged;
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.BackColor = Color.Transparent;
            lblKategori.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblKategori.Location = new Point(103, 66);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(93, 17);
            lblKategori.TabIndex = 0;
            lblKategori.Text = "Kategoriler :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(137, 104);
            label1.Name = "label1";
            label1.Size = new Size(50, 17);
            label1.TabIndex = 0;
            label1.Text = "Ürün :";
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(221, 66);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(138, 23);
            cmbKategori.TabIndex = 1;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(221, 101);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(138, 23);
            txtAd.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(137, 147);
            label2.Name = "label2";
            label2.Size = new Size(49, 17);
            label2.TabIndex = 3;
            label2.Text = "Fiyat :";
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(221, 133);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(138, 23);
            txtFiyat.TabIndex = 4;
            // 
            // btnKaydet
            // 
            btnKaydet.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnKaydet.Location = new Point(180, 375);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(87, 35);
            btnKaydet.TabIndex = 5;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuncelle.Location = new Point(296, 375);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(88, 35);
            btnGuncelle.TabIndex = 5;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(103, 192);
            label3.Name = "label3";
            label3.Size = new Size(113, 17);
            label3.TabIndex = 8;
            label3.Text = "Ürün Fotoğrafı :";
            // 
            // pcFoto
            // 
            pcFoto.BackColor = Color.Transparent;
            pcFoto.BackgroundImageLayout = ImageLayout.Stretch;
            pcFoto.BorderStyle = BorderStyle.Fixed3D;
            pcFoto.Location = new Point(221, 173);
            pcFoto.Name = "pcFoto";
            pcFoto.Padding = new Padding(3);
            pcFoto.Size = new Size(138, 156);
            pcFoto.TabIndex = 7;
            pcFoto.TabStop = false;
            pcFoto.Click += pictureBox1_Click;
            // 
            // UrunForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(662, 464);
            Controls.Add(lstUrun);
            Controls.Add(label3);
            Controls.Add(pcFoto);
            Controls.Add(btnGuncelle);
            Controls.Add(btnKaydet);
            Controls.Add(txtFiyat);
            Controls.Add(label2);
            Controls.Add(txtAd);
            Controls.Add(cmbKategori);
            Controls.Add(label1);
            Controls.Add(lblKategori);
            Name = "UrunForm";
            Text = "UrunForm";
            Load += UrunForm_Load;
            cmsSil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private OpenFileDialog dosyaAc;
        private SaveFileDialog dosyaKaydet;
        private ContextMenuStrip cmsSil;
        private ToolStripMenuItem silToolStripMenuItem;
        private ListBox lstUrun;
        private Label lblKategori;
        private Label label1;
        private ComboBox cmbKategori;
        private TextBox txtAd;
        private Label label2;
        private TextBox txtFiyat;
        private Button btnKaydet;
        private Button btnGuncelle;
        private Label label3;
        private PictureBox pcFoto;
    }
}