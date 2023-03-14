
namespace CafeOtomasyonu.Classes
{
    public class Kat :  BaseModel
    {

        public string Ad { get; set; }
        public int MasaSayisi { get; set; }

        public override string ToString()
        {
            return $"{Ad}-{MasaSayisi}";
        }
    }
}
