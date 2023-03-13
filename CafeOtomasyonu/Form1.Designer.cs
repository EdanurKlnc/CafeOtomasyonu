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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnKategori = new Button();
            btnKat = new Button();
            btnUrunler = new Button();
            SuspendLayout();
            // 
            // btnKategori
            // 
            btnKategori.Location = new Point(211, 72);
            btnKategori.Name = "btnKategori";
            btnKategori.Size = new Size(81, 32);
            btnKategori.TabIndex = 0;
            btnKategori.Text = "Kategori";
            btnKategori.UseVisualStyleBackColor = true;
            btnKategori.Click += btnKategori_Click;
            // 
            // btnKat
            // 
            btnKat.Location = new Point(211, 126);
            btnKat.Name = "btnKat";
            btnKat.Size = new Size(81, 32);
            btnKat.TabIndex = 1;
            btnKat.Text = "Kat";
            btnKat.UseVisualStyleBackColor = true;
            btnKat.Click += btnKat_Click;
            // 
            // btnUrunler
            // 
            btnUrunler.Location = new Point(211, 182);
            btnUrunler.Name = "btnUrunler";
            btnUrunler.Size = new Size(81, 32);
            btnUrunler.TabIndex = 2;
            btnUrunler.Text = "ürünler";
            btnUrunler.UseVisualStyleBackColor = true;
            btnUrunler.Click += btnUrunler_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(695, 414);
            Controls.Add(btnUrunler);
            Controls.Add(btnKat);
            Controls.Add(btnKategori);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnKategori;
        private Button btnKat;
        private Button btnUrunler;
    }
}