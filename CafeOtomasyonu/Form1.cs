using CafeOtomasyonu.Forms;

namespace CafeOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void btnKategori_Click(object sender, EventArgs e)
        {
            KategoriForm kategoriForm = new KategoriForm();
            kategoriForm.Show();
            this.Hide();
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
