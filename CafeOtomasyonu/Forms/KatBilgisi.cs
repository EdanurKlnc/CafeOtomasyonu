using CafeOtomasyonu.Classes;
using CafeOtomasyonu.Data;
using CafeOtomasyonu.Helpers;

namespace CafeOtomasyonu.Forms
{
    public partial class KatBilgisi : Form
    {
        public KatBilgisi()
        {
            InitializeComponent();
        }
        public EnvanterContext DataContext { get; set; }

        private void KatBilgisi_Load(object sender, EventArgs e)
        {
            lstKat.DataSource = DataContext.Katlar;

        }
        private void btnKatUret_Click(object sender, EventArgs e)
        {
            try
            {
                Kat kat = new Kat()
                {
                    Ad = txtbxKatBilgi.Text,
                    MasaSayisi = Convert.ToInt32(txtMasaSayisi.Text)
                };
                DataContext.Katlar.Add(kat);
                lstKat.DataSource = null;
                lstKat.DataSource = DataContext.Katlar;
                DataHelper.Save(DataContext);
                this.FormCleaner(Controls);
                for (int i = 1; i <= kat.MasaSayisi; i++)
                {
                    Masa masa = new Masa()
                    {
                        BulunduguKat = kat,
                        Ad = "MASA" + i.ToString()
                    };
                    DataContext.Masalar.Add(masa);
                }
                DataHelper.Save(DataContext);
            }
            catch
            {
                MessageBox.Show($"Hata var!!");
            }
        }


    }
}


/* flw1.Controls.Clear();
 int katSayisi = int.Parse(txtbxKatBilgi.Text);
 for (int kat = 1; kat <= katSayisi; kat++)
 {

     string btnKat = $"{kat}.Kat";
     Button yeniButon = ButonUret(btnKat);
     flw1.Controls.Add(yeniButon);*/

/*
    private Button ButonUret(string btnKat)
    {
        Button btn = new Button()
        {
            Text = btnKat,
            Size = new Size(194, 40),
        };

        btn.Click += BtnKatSayisi_Click;
        return btn;
    }

    private void BtnKatSayisi_Click(object? sender, EventArgs e)
    {

        Button basilanButon = (Button)sender;
        this.Text = basilanButon.Text;

    }

    private void KatBilgisi_Load(object sender, EventArgs e)
    {
    lstKatlar.DataSource = DataContext.Katlar;

}
*/

