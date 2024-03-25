namespace coin
{
    public class Money
    {
        public double Coin { get; set; }
        public ValutaType Valuta { get; set; }

        public Money(double coin, ValutaType valuta)
        {
            Coin = coin;
            Valuta = valuta;
        }

        public override string ToString()
        {
            return $"Amount: {Coin} Valuta: {Valuta}";
        }
    }
}
