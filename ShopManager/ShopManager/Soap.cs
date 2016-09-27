namespace ShopManager
{
    public class Soap : Ware
    {
        public readonly char WASHEFFECT_A = 'A';
        public readonly char WASHEFFECT_B = 'B';
        readonly char washEffect;

        public Soap(long barcode, string company, char washEffect) : base(barcode, company)
        {
            this.washEffect = washEffect;
        }
    }
}
