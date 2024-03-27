namespace Adapter
{
    public class EuropeanCharger : ICharger
    {
        public string chargePhone(EuropeanSocket europeanSocket)
        {
            return $"Charging phone using {europeanSocket.ToString()} with {europeanSocket.Power}";
        }
    }
}
