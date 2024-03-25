namespace Coin
{
    class Program
    { 
        public static void Main()
        {
            Bank bank = new Bank();
            Coin coin1 = new Coin(2, Coin.Valuta.USD);
            Coin coin2 = new Coin(10, Coin.Valuta.EUR);
            Coin coin3 = new Coin(100, Coin.Valuta.UAH);

            bank.AddCoin(coin1);
            bank.AddCoin(coin2);
            bank.AddCoin(coin3);
            
            bank.Count();
            bank.PrintCoins();
        }
    }
}