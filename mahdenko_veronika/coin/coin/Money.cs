namespace coin
{
    public class Money
    {
        public double coin;
        public ValutaType valuta;

        public Money(double _coin, ValutaType _valuta)
        {
            coin = _coin;
            valuta = _valuta;
        }

        public override string ToString()
        {
            return $"Amount: {coin} Valuta: {valuta}";
        }
    }
}
