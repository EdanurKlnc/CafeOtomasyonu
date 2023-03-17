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
            btnKategori.BackColor = Color.SandyBrown;
            btnKategori.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnKategori.Location = new Point(445, 132);
            btnKategori.Name = "btnKategori";
            btnKategori.Size = new Size(178, 61);
            btnKategori.TabIndex = 0;
            btnKategori.Text = "Kategori";
            btnKategori.UseVisualStyleBackColor = false;
            btnKategori.Click += btnKategori_Click;
            // 
            // btnKat
            // 
            btnKat.BackColor = Color.SandyBrown;
            btnKat.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnKat.Location = new Point(517, 219);
            btnKat.Name = "btnKat";
            btnKat.Size = new Size(178, 61);
            btnKat.TabIndex = 1;
            btnKat.Text = "Kat";
            btnKat.UseVisualStyleBackColor = false;
            btnKat.Click += btnKat_Click;
            // 
            // btnUrunler
            // 
            btnUrunler.BackColor = Color.SandyBrown;
            btnUrunler.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnUrunler.ForeColor = SystemColors.ControlText;
            btnUrunler.Location = new Point(601, 304);
            btnUrunler.Name = "btnUrunler";
            btnUrunler.Size = new Size(178, 61);
            btnUrunler.TabIndex = 2;
            btnUrunler.Text = "Ürünler";
            btnUrunler.UseVisualStyleBackColor = false;
            btnUrunler.Click += btnUrunler_Click;
            // 
            // btnAnasayfa
            // 
            btnAnasayfa.BackColor = Color.Chocolate;
            btnAnasayfa.Font = new Font("Segoe Print", 18F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            btnAnasayfa.ForeColor = Color.Black;
            btnAnasayfa.Location = new Point(358, 48);
            btnAnasayfa.Name = "btnAnasayfa";
            btnAnasayfa.Size = new Size(178, 61);
            btnAnasayfa.TabIndex = 3;
            btnAnasayfa.Text = "ANASAYFA";
            btnAnasayfa.UseVisualStyleBackColor = false;
            btnAnasayfa.Click += btnAnasayfa_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(811, 407);
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