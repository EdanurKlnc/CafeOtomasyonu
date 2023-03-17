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
            btnAnasayfa = new Button();
            SuspendLayout();
            // 
            // btnKategori
            // 
            btnKategori.BackColor = Color.White;
            btnKategori.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnKategori.Location = new Point(74, 165);
            btnKategori.Name = "btnKategori";
            btnKategori.Size = new Size(127, 39);
            btnKategori.TabIndex = 0;
            btnKategori.Text = "Kategori";
            btnKategori.UseVisualStyleBackColor = false;
            btnKategori.Click += btnKategori_Click;
            // 
            // btnKat
            // 
            btnKat.BackColor = Color.White;
            btnKat.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnKat.Location = new Point(74, 219);
            btnKat.Name = "btnKat";
            btnKat.Size = new Size(127, 39);
            btnKat.TabIndex = 1;
            btnKat.Text = "Kat";
            btnKat.UseVisualStyleBackColor = false;
            btnKat.Click += btnKat_Click;
            // 
            // btnUrunler
            // 
            btnUrunler.BackColor = Color.White;
            btnUrunler.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnUrunler.Location = new Point(74, 275);
            btnUrunler.Name = "btnUrunler";
            btnUrunler.Size = new Size(127, 39);
            btnUrunler.TabIndex = 2;
            btnUrunler.Text = "Ürünler";
            btnUrunler.UseVisualStyleBackColor = false;
            btnUrunler.Click += btnUrunler_Click;
            // 
            // btnAnasayfa
            // 
            btnAnasayfa.BackColor = Color.SaddleBrown;
            btnAnasayfa.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAnasayfa.ForeColor = Color.White;
            btnAnasayfa.Location = new Point(64, 78);
            btnAnasayfa.Name = "btnAnasayfa";
            btnAnasayfa.Size = new Size(147, 66);
            btnAnasayfa.TabIndex = 3;
            btnAnasayfa.Text = "Anasayfa";
            btnAnasayfa.UseVisualStyleBackColor = false;
            btnAnasayfa.Click += btnAnasayfa_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(695, 414);
            Controls.Add(btnAnasayfa);
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
        private Button btnAnasayfa;
    }
}