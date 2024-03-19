using System;
using System.Collections;

namespace Coin
{
    class Bank
    {
        private List<Coin> list = new List<Coin>();

        public void AddCoin(Coin coin)
        {
            list.Add(coin);
        }

        public void Count()
        {
            Dictionary<Coin.Valuta, int> dict = new Dictionary<Coin.Valuta, int>();

            foreach (Coin coin in list)
            {
                if (dict.ContainsKey(coin.valuta))
                {
                    dict[coin.valuta] += coin.amount;
                }
                else
                {
                    dict[coin.valuta] = coin.amount;
                }
            }
        }
        public void PrintCoins()
        {
            Console.WriteLine("Piggy bank:");

            foreach (Coin coin in list)
            {
                string currencyName;
                if (coin.valuta == Coin.Valuta.USD)
                {
                    currencyName = "dollars";
                }
                else if (coin.valuta == Coin.Valuta.EUR)
                {
                    currencyName = "euros";
                }
                else
                {
                    currencyName = "uahs";
                }
                Console.WriteLine($"{coin.amount} {currencyName}");
            }
        }
    }
}
