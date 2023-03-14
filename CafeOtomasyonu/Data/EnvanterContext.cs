using CafeOtomasyonu.Classes;

namespace CafeOtomasyonu.Data;

public class EnvanterContext
{
    public List<Urun> Urunler { get; set; } = new();
    public List<Kategori> Kategoriler { get; set; } = new();

    public List<Kat> Katlar { get; set; } = new ();
    public List<Masa> Masalar { get; set; } = new List<Masa>();
}
