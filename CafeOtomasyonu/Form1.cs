using CafeOtomasyonu.Data;
using CafeOtomasyonu.Forms;
using CafeOtomasyonu.Helpers;

namespace CafeOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private KategoriForm _kategoriForm;
        private AnaMenu _anaMenuForm;
        private UrunForm _urunForm;
        private EnvanterContext _dataContext;
        private KatBilgisi _katBilgisi;



        private void btnKategori_Click(object sender, EventArgs e)
        {

            if (_kategoriForm == null || _kategoriForm.IsDisposed)
            {
                _kategoriForm = new KategoriForm();
                _kategoriForm.Text = "Kategori Sayfasý";
                _kategoriForm.DataContext = _dataContext;
                _kategoriForm.Show();
            }
        }

        private void btnKat_Click(object sender, EventArgs e)
        {
            if (_katBilgisi == null || _katBilgisi.IsDisposed)
            {
                _katBilgisi = new KatBilgisi();
                _katBilgisi.Text = "Kat Bilgisi";
                _katBilgisi.DataContext = _dataContext;
                _katBilgisi.Show();
            }

        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            if (_urunForm == null || _urunForm.IsDisposed)
            {
                _urunForm = new UrunForm();
                _urunForm.Text = "Kategori Sayfasý";
                _urunForm.DataContext = _dataContext;
                _urunForm.Show();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var data = DataHelper.Load();
            _dataContext = data ?? new();
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            if (_anaMenuForm == null || _anaMenuForm.IsDisposed)
            {
                _anaMenuForm = new AnaMenu();
                _anaMenuForm.Text = "Kat Bilgisi";
                _anaMenuForm.DataContext = _dataContext;
                _anaMenuForm.Show();
            }
        }


        //if (_kategoriForm == null || _kategoriForm.IsDisposed)
        //{
        //    _kategoriForm = new KategoriForm();
        //    _kategoriForm.MdiParent = this;
        //    _kategoriForm.Text = "Kategori";
        //    _kategoriForm.Show();
        //}
    }
}
