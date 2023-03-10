namespace CafeOtomasyonu.Data;

public class EnvanterContext
{
    public List<Urun> Urunler { get; set; } = new();
    public List<Kategori> Kategoriler {get; set;}  =new();

}
