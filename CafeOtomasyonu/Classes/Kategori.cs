
namespace CafeOtomasyonu;

public class Kategori
{
    public string Ad { get; set; }
    public List<Urun> Urunler { get; set; } = new List<Urun>();
        public override string ToString()
    {
        return this.Ad;
    }
}
