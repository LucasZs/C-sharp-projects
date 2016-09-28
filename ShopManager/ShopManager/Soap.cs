namespace ShopManager
{
    public class Soap : Ware
    {
        public static readonly char WASHEFFECT_A = 'A';
        public static readonly char WASHEFFECT_B = 'B';
        readonly char washEffect;

        public Soap(long barcode, string company, char washEffect) : base(barcode, company)
        {
            this.washEffect = washEffect;
        }
    }
}
