
namespace CafeOtomasyonu;

public class Urun : BaseModel
{
    public Guid Id { get; set; }
    public string Ad { get; set; }
    public Kategori Kategori {get;set;}
    public string Fiyat { get; set; }
    public byte[] Fotograf { get; set; }
    //public Kategori BulunduguKategori { get; set; }
    public override string ToString()
    {
        return $"{ this.Ad} - { this.Fiyat}";
    }
    
}
