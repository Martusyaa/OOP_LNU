namespace coin
{
    class Program
    {
        static void Main()
        {
            Bank bank = new Bank();
            Dictionary<ValutaType, double> currencyTotals = new Dictionary<ValutaType, double>();

            bank.AddMoney(1, ValutaType.USD, currencyTotals);
            bank.AddMoney(5, ValutaType.EUR, currencyTotals);
            bank.AddMoney(10, ValutaType.UAH, currencyTotals);
            bank.AddMoney(1, ValutaType.USD, currencyTotals);
            bank.AddMoney(60, ValutaType.UAH, currencyTotals);

            Console.WriteLine(bank.MoneyInBank());
        }
    }
}