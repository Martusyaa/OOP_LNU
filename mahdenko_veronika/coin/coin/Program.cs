namespace coin
{
    class Program
    {
        static void Main()
        {
            Bank bank = new Bank();
            bank.AddMoney(1, ValutaType.USD);
            bank.AddMoney(5, ValutaType.EUR);
            bank.AddMoney(10, ValutaType.UAH);
            bank.AddMoney(1, ValutaType.USD);
            bank.AddMoney(60, ValutaType.UAH);

            Console.WriteLine(bank.MoneyInBank());
        }
    }
}