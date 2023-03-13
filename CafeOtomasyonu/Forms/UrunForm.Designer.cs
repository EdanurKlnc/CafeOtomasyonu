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
            lblKategori = new Label();
            label1 = new Label();
            cmbKategori = new ComboBox();
            txtAd = new TextBox();
            label2 = new Label();
            txtFiyat = new TextBox();
            btnKaydet = new Button();
            btnGuncelle = new Button();
            lstUrun = new ListBox();
            cmsSil = new ContextMenuStrip(components);
            silToolStripMenuItem = new ToolStripMenuItem();
            pcFoto = new PictureBox();
            dosyaAc = new OpenFileDialog();
            dosyaKaydet = new SaveFileDialog();
            cmsSil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcFoto).BeginInit();
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
            // txtAd
            // 
            txtAd.Location = new Point(136, 76);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(166, 23);
            txtAd.TabIndex = 2;
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
            btnKaydet.Location = new Point(120, 376);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(87, 67);
            btnKaydet.TabIndex = 5;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(218, 376);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(84, 67);
            btnGuncelle.TabIndex = 5;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // lstUrun
            // 
            lstUrun.ContextMenuStrip = cmsSil;
            lstUrun.FormattingEnabled = true;
            lstUrun.ItemHeight = 15;
            lstUrun.Location = new Point(332, 34);
            lstUrun.Name = "lstUrun";
            lstUrun.Size = new Size(202, 409);
            lstUrun.TabIndex = 6;
            lstUrun.SelectedIndexChanged += lstUrun_SelectedIndexChanged;
            // 
            // cmsSil
            // 
            cmsSil.Items.AddRange(new ToolStripItem[] { silToolStripMenuItem });
            cmsSil.Name = "cmsSil";
            cmsSil.Size = new Size(181, 48);
            // 
            // silToolStripMenuItem
            // 
            silToolStripMenuItem.Name = "silToolStripMenuItem";
            silToolStripMenuItem.Size = new Size(180, 22);
            silToolStripMenuItem.Text = "Sil";
            silToolStripMenuItem.Click += silToolStripMenuItem_Click;
            // 
            // pcFoto
            // 
            pcFoto.BackColor = Color.IndianRed;
            pcFoto.Location = new Point(131, 179);
            pcFoto.Name = "pcFoto";
            pcFoto.Size = new Size(171, 180);
            pcFoto.TabIndex = 7;
            pcFoto.TabStop = false;
            pcFoto.Click += pictureBox1_Click;
            // 
            // dosyaAc
            // 
            dosyaAc.FileName = "dosyaAc";
            // 
            // dosyaKaydet
            // 
            dosyaKaydet.FileName = "dosyaKaydet";
            // 
            // UrunForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 464);
            Controls.Add(pcFoto);
            Controls.Add(lstUrun);
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

        private Label lblKategori;
        private Label label1;
        private ComboBox cmbKategori;
        private TextBox txtAd;
        private Label label2;
        private TextBox txtFiyat;
        private Button btnKaydet;
        private Button btnGuncelle;
        private ListBox lstUrun;
        private PictureBox pcFoto;
        private OpenFileDialog dosyaAc;
        private SaveFileDialog dosyaKaydet;
        private ContextMenuStrip cmsSil;
        private ToolStripMenuItem silToolStripMenuItem;
    }
}