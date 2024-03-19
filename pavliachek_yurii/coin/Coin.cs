namespace Coin
{
    class Coin
    {
        public int amount { get; set; }
        public Valuta valuta { get; set; }

        public enum Valuta
        {
            USD, EUR, UAH
        }
        public Coin(int amount, Valuta valuta)
        {
            this.amount = amount;
            this.valuta = valuta;
        }
    }
}
