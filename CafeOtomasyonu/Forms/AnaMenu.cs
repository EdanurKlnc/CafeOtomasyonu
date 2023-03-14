
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
            foreach (var item in DataContext.Katlar)
            {
                Button btn = new Button();
                btn.Text = item.Ad;
                btn.Size = new Size(180, 50);
                //btn.Click += KatButon_Click;
                flpKatBilgisi.Controls.Add(btn);

            }
        }
    }
}
