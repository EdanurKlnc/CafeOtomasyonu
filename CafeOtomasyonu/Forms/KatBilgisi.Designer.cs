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
            btnKat = new Button();
            flw1 = new FlowLayoutPanel();
            flw1.SuspendLayout();
            SuspendLayout();
            // 
            // txtbxKatBilgi
            // 
            txtbxKatBilgi.Location = new Point(202, 35);
            txtbxKatBilgi.Name = "txtbxKatBilgi";
            txtbxKatBilgi.Size = new Size(162, 23);
            txtbxKatBilgi.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(42, 40);
            label1.Name = "label1";
            label1.Size = new Size(141, 18);
            label1.TabIndex = 1;
            label1.Text = "Kat Sayısı Giriniz :";
            // 
            // btnKatUret
            // 
            btnKatUret.Location = new Point(42, 101);
            btnKatUret.Name = "btnKatUret";
            btnKatUret.Size = new Size(116, 79);
            btnKatUret.TabIndex = 2;
            btnKatUret.Text = "KAT ÜRET";
            btnKatUret.UseVisualStyleBackColor = true;
            btnKatUret.Click += btnKatUret_Click;
            // 
            // btnKat
            // 
            btnKat.Location = new Point(3, 3);
            btnKat.Name = "btnKat";
            btnKat.Size = new Size(192, 40);
            btnKat.TabIndex = 2;
            btnKat.Text = "button1";
            btnKat.UseVisualStyleBackColor = true;
            // 
            // flw1
            // 
            flw1.AutoScroll = true;
            flw1.Controls.Add(btnKat);
            flw1.Location = new Point(400, 35);
            flw1.Name = "flw1";
            flw1.Size = new Size(224, 442);
            flw1.TabIndex = 4;
            // 
            // KatBilgisi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 502);
            Controls.Add(flw1);
            Controls.Add(btnKatUret);
            Controls.Add(label1);
            Controls.Add(txtbxKatBilgi);
            Name = "KatBilgisi";
            Text = "KatBilgisi";
            Load += KatBilgisi_Load;
            flw1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbxKatBilgi;
        private Label label1;
        private Button btnKatUret;
        private Button btnKat;
        private FlowLayoutPanel flw1;
    }
}