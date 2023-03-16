using CafeOtomasyonu.Classes;

namespace CafeOtomasyonu.Data;

public class EnvanterContext
{
    public List<Urun> Urunler { get; set; } = new List<Urun>();
    public List<Kategori> Kategoriler { get; set; } = new List<Kategori>();
    public List<Kat> Katlar { get; set; } = new List<Kat>();
    public List<Masa> Masalar { get; set; } = new List<Masa>();
}
