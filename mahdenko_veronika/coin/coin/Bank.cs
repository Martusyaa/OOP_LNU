using System.Linq;
namespace coin
{
    public class Bank
    {
        private List<Money> moneyCollection;

        public Bank()
        {
            moneyCollection = new List<Money>();
        }

        public void AddMoney(double coin, ValutaType valuta, Dictionary<ValutaType, double> currencyTotals)
        {
            Money money = new Money(coin, valuta);
            moneyCollection.Add(money);

            if (currencyTotals.ContainsKey(valuta))
            {
                currencyTotals[valuta] += coin;
            }
            else
            {
                currencyTotals[valuta] = coin;
            }
        }

        public double MoneyInBank()
        {
            Console.WriteLine("Money in bank:");
            moneyCollection.Select(m => m.ToString()).ToList().ForEach(Console.WriteLine);

            Dictionary<ValutaType, double> currencyTotals = moneyCollection
                .GroupBy(m => m.Valuta)
                .ToDictionary(g => g.Key, g => g.Sum(m => m.Coin));

            Console.WriteLine("Currency totals:");
            currencyTotals.ToList().ForEach(i => Console.WriteLine($"{i.Key}: {i.Value}"));

            double totalMoney = moneyCollection.Sum(m => m.Coin);
            Console.WriteLine("Suma coins: ");
            return totalMoney;
        }
    }
}

