using CafeOtomasyonu.Data;
using CafeOtomasyonu.Helpers;

namespace CafeOtomasyonu.Forms
{
    public partial class UrunForm : Form
    {
        public UrunForm()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Urun urun = new()
                {
                    Ad = txtAd.Text,
                    Fiyat = txtFiyat.Text,
                    Kategori = (Kategori)cmbKategori.SelectedItem
                };
                if (pcFoto.Image != null)
                {
                    urun.Fotograf = (byte[])(new ImageConverter().ConvertTo(pcFoto.Image, typeof(byte[])));
                }
                else
                    urun.Fotograf = null;

                DataContext.Urunler.Add(urun);
                lstUrun.DataSource = null;
                lstUrun.DataSource = DataContext.Urunler;
                DataHelper.Save(DataContext);
                this.FormCleaner(Controls);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata!");
            }
        }
        public EnvanterContext DataContext { get; set; }
        private void UrunForm_Load(object sender, EventArgs e)
        {
            cmbKategori.DataSource = DataContext.Kategoriler;
            lstUrun.DataSource = DataContext.Urunler;
 }

        private void lstUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUrun.SelectedItem == null) return;
            Urun urun = (Urun)lstUrun.SelectedItem;
            txtAd.Text = urun.Ad;
            txtFiyat.Text = urun.Fiyat;
            cmbKategori.SelectedItem = DataContext.Kategoriler.Find(x => x.Id == urun.Kategori.Id);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstUrun.SelectedItem == null) return;
            Urun urun = (Urun)lstUrun.SelectedItem;
            urun.Ad = txtAd.Text;
            urun.Fiyat = txtFiyat.Text;
            urun.Kategori = (Kategori)cmbKategori.SelectedItem;
            lstUrun.DataSource = null;
            lstUrun.DataSource = DataContext.Urunler;
            DataHelper.Save(DataContext);
            this.FormCleaner(Controls);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyaAc = new OpenFileDialog();
            dosyaAc.Title = "Resim Seçiniz";
            dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dosyaAc.Multiselect = false;
            dosyaAc.Filter = "Resim Dosyası |*.jpg;*.png;*.jpeg;";
            if (dosyaAc.ShowDialog() == DialogResult.OK)
            {
                pcFoto.Image = Image.FromFile(dosyaAc.FileName);
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstUrun.SelectedItem == null) return;
            var seciliUrun = lstUrun.SelectedItem as Urun;
            DialogResult result = MessageBox.Show($"{seciliUrun.Ad} ürününü silmek istiyor musunuz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DataContext.Urunler.Remove(seciliUrun);
                lstUrun.DataSource = null;
                lstUrun.DataSource = DataContext.Urunler;
                DataHelper.Save(DataContext);

            }
        }


    }
}
