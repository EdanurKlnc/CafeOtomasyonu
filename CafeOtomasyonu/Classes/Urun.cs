
namespace CafeOtomasyonu;

public class Urun :BaseModel
{
    public string Ad { get; set; }
    public string Fiyat { get; set; }
    public byte[] Fotograf { get; set; }
    public override string ToString()
    {
        return $"{ this.Ad} - { this.Fiyat}";
    }
    
}
