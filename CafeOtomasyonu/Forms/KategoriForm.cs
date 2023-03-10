using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOtomasyonu.Forms
{
    public partial class KategoriForm : Form
    {
        public KategoriForm()
        {
            InitializeComponent();
        }

        public List<Kategori> Kategoriler { get; set; } = new();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Kategori kategori = new Kategori()
                {
                    Ad = txtAd.Text
                };
                Kategoriler.Add(kategori);
                lstKategori.DataSource = null;
                lstKategori.DataSource = Kategoriler;

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
                lstKategori.DataSource = Kategoriler;

            }
            catch
            {
                throw;
            }
        }
    }
}
