namespace coin
{
    public class Bank
    {
        private List<Money> moneyCollection;
        private Dictionary<ValutaType, double> currencyTotals;

        public Bank()
        {
            moneyCollection = new List<Money>();
            currencyTotals = new Dictionary<ValutaType, double>();
        }

        public void AddMoney(double coin, ValutaType valuta)
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
            foreach (var money in moneyCollection)
            {
                Console.WriteLine(money);
            }

            Console.WriteLine("Currency totals:");
            foreach (var i in currencyTotals)
            {
                Console.WriteLine($"{i.Key}: {i.Value}");
            }
            double totalMoney = 0;
            foreach (var money in moneyCollection)
            {
                totalMoney += money.coin;
            }
            Console.WriteLine("Suma coins: ");
            return totalMoney;
        }
    }
}

