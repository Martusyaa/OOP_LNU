namespace Adapter
{
    public class AmericanCharger
    {
        public string chargePhone(AmericanSocket americanSocket)
        {
            return $"Charging phone using {americanSocket.ToString()} with {americanSocket.Power}";
        }
    }
}
