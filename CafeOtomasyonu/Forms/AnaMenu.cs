﻿
using CafeOtomasyonu.Data;

namespace CafeOtomasyonu.Forms
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        public EnvanterContext DataContext { get; set; }


        private void AnaMenu_Load(object sender, EventArgs e)
        {
            flpMasalar.Controls.Clear();
            flpKategoriler.Controls.Clear();
            //diğer formda eklenen kat bilgisini bu formda yazdırma
            foreach (var item in DataContext.Katlar)
            {
                Button btn = new Button();
                btn.Text = ($"{item.Ad}.Kat");
                btn.Size = new Size(150, 50);
                btn.BackColor = Color.OrangeRed;
                btn.Font = new Font("Segoe Print", 16F, FontStyle.Regular, GraphicsUnit.Point);
                flpKatBilgisi.Controls.Add(btn);
                btn.Click += MasaOlustur; //kata tıklandığında masa oluşturacak

            }
        }

        private void MasaOlustur(object? sender, EventArgs e)
        {
            flpMasalar.Controls.Clear();
            flpKategoriler.Controls.Clear();
            flpUrunler.Controls.Clear();

            var tiklananKat = ((Button)sender).Text.Substring(0, 1);

            foreach (var item in DataContext.Masalar)
            {
                if (item.BulunduguKat.Ad == tiklananKat)
                {
                    Button btnMasa = new Button();
                    btnMasa.Name = item.Id.ToString();
                    btnMasa.Text = ($"{item.Ad}");
                    btnMasa.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
                    btnMasa.Size = new Size(100, 50);
                    btnMasa.BackColor = Color.Silver;
                    btnMasa.Click += KategoriGetir;
                    flpMasalar.Controls.Add(btnMasa);
                }

            }
        }

        private void KategoriGetir(object? sender, EventArgs e)
        {
            flpUrunler.Controls.Clear();
            foreach (var item in DataContext.Kategoriler)
            {

                Button btnKategori = new Button();
                btnKategori.Click += UrunGetir;
                btnKategori.Text = ($"{item.Ad}");
                btnKategori.Size = new Size(120, 40);
                btnKategori.BackColor = Color.Pink;
                flpKategoriler.Controls.Add(btnKategori);
            }
        }

        private void UrunGetir(object? sender, EventArgs e)
        {
            flpUrunler.Controls.Clear();
            foreach (var item in DataContext.Urunler)
            {
                Button btnUrunler = new Button();
                btnUrunler.Text = ($"{item.Ad}");
                btnUrunler.Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point);
                btnUrunler.ForeColor = Color.White;
                btnUrunler.BackgroundImage = (Image)(new ImageConverter().ConvertFrom(item.Fotograf));
                btnUrunler.BackgroundImageLayout = ImageLayout.Stretch;
                btnUrunler.Size = new Size(150, 150);
                btnUrunler.BackColor = Color.Pink;
                flpUrunler.Controls.Add(btnUrunler);
            }
        }
    }
}

/*
      private void MasaOlustur(object? sender, EventArgs e)
      {

          flpUrunler.Controls.Clear();
          flpMasalar.Controls.Clear();
          //flpKatBilgisi.Controls.Clear();
          foreach (var item in DataContext.Masalar)
          {
              Button btnMasa = new Button();
              btnMasa.Text = ($"{item.Ad}");
              btnMasa.Size = new Size(100, 50);
              btnMasa.BackColor = Color.Aqua;
              btnMasa.Click += KategoriGetir;
              flpMasalar.Controls.Add(btnMasa);

          }
      }*/