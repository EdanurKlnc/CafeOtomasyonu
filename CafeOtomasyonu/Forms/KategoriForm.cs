using CafeOtomasyonu.Data;
using CafeOtomasyonu.Helpers;

namespace CafeOtomasyonu.Forms
{
    public partial class KategoriForm : Form
    {
        public KategoriForm()
        {
            InitializeComponent();
        }

        // public List<Kategori> Kategoriler { get; set; } = new();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Kategori kategori = new Kategori()
                {
                    Ad = txtAd.Text
                };
                DataContext.Kategoriler.Add(kategori);
                lstKategori.DataSource = null;
                lstKategori.DataSource = DataContext.Kategoriler;
                DataHelper.Save(DataContext);
                this.FormCleaner(Controls);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata {ex.Message}");
            }
        }

        private void lstKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKategori.SelectedItem == null)
            {
                return;

            }
            Kategori seciliKategori = (Kategori)lstKategori.SelectedItem;
            txtAd.Text = seciliKategori.Ad;

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstKategori.SelectedItem == null)
            {
                return;

            }
            Kategori seciliKategori = (Kategori)lstKategori.SelectedItem;
            try
            {
                seciliKategori.Ad = txtAd.Text;
                lstKategori.DataSource = null;
                lstKategori.DataSource = DataContext.Kategoriler;
                DataHelper.Save(DataContext);
                this.FormCleaner(Controls);

            }
            catch
            {
                throw;
            }
        }
        public EnvanterContext DataContext { get; set; }
        private void KategoriForm_Load(object sender, EventArgs e)
        {
            lstKategori.DataSource = DataContext.Kategoriler;
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
