namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            EuropeanSocket europeanSocket = new EuropeanSocket("200V");
            ICharger europeanCharger = new EuropeanCharger();
            System.Console.WriteLine(europeanCharger.chargePhone(europeanSocket));
            Adapter americanAdapter = new Adapter();
            AmericanCharger americanCharger = new AmericanCharger();
            System.Console.WriteLine(
                americanCharger.chargePhone(americanAdapter.changeSocket(europeanSocket))
            );
        }
    }
}
