
namespace CafeOtomasyonu;

public class Urun
{
    public string Ad { get; set; }
    public string Fiyat { get; set; }
    public byte[] Fotograf { get; set; }
    public override string ToString()
    {
        return $"{ this.Ad} - { this.Fiyat}";
    }
    
}
