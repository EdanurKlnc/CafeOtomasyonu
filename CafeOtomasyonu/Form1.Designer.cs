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
            btnKategori = new Button();
            SuspendLayout();
            // 
            // btnKategori
            // 
            btnKategori.Location = new Point(292, 366);
            btnKategori.Name = "btnKategori";
            btnKategori.Size = new Size(75, 23);
            btnKategori.TabIndex = 0;
            btnKategori.Text = "Kategori";
            btnKategori.UseVisualStyleBackColor = true;
            btnKategori.Click += btnKategori_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 498);
            Controls.Add(btnKategori);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnKategori;
    }
}