
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
            //diğer formda eklenen kat bilgisini bu formda yazdırma
            foreach (var item in DataContext.Katlar)
            {
                Button btn = new Button();
                btn.Text = ($"{item.Ad}.Kat");
                btn.Size = new Size(150, 50);
                btn.BackColor = Color.OrangeRed;
                flpKatBilgisi.Controls.Add(btn);
                btn.Click += KatOlustur;

            }
        }

        private void KatOlustur(object? sender, EventArgs e)
        {

            flpUrunler.Controls.Clear();
            flpMasalar.Controls.Clear();
            //flpKatBilgisi.Controls.Clear();
            foreach (var item in DataContext.Masalar)
            {
                //TODO : kata göre masa sayısı gelmiyor
               // if ((sender as Button).Text == item.BulunduguKat.Ad)}
                {
                    Button btnKat = new Button();
                    btnKat.Text = ($"{item.Ad}");
                    btnKat.Size = new Size(100, 50);
                    btnKat.BackColor = Color.Aqua;
                    btnKat.Click += MasaOlustur;
                    flpMasalar.Controls.Add(btnKat);


            }
        }
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
        }

        private void KategoriGetir(object? sender, EventArgs e)
        {
            flpUrunler.Controls.Clear();
            foreach (var item in DataContext.Kategoriler)
            {
                Button btn = new Button();
                btn.Text = ($"{item.Ad}");
                btn.Size = new Size(120, 40);
                btn.BackColor = Color.Pink;
                flpUrunler.Controls.Add(btn);
            }

        }
    }
}

