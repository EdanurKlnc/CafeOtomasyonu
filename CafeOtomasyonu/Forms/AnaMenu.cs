
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

            }
        }
    }
}
