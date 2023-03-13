namespace CafeOtomasyonu.Forms
{
    public partial class KatBilgisi : Form
    {
        public KatBilgisi()
        {
            InitializeComponent();
        }

        private void btnKatUret_Click(object sender, EventArgs e)
        {

            flw1.Controls.Clear();
            int katSayisi = int.Parse(txtbxKatBilgi.Text);
            for (int kat = 1; kat <= katSayisi; kat++)
            {

                string btnKat = $"{kat}.Kat";
                Button yeniButon = ButonUret(btnKat);
                flw1.Controls.Add(yeniButon);
            }
        }

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

        }
    }
}
