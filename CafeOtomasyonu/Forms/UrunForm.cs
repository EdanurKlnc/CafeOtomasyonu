using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                DataContext.Urunler.Add(urun);
                lstUrun.DataSource = null;
                lstUrun.DataSource = DataContext.Urunler;
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
        }

    }
}
