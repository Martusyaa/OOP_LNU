namespace Adapter
{
    public class Adapter
    {
        public AmericanSocket changeSocket(EuropeanSocket europeanSocket)
        {
            AmericanSocket americanSocket = new AmericanSocket(europeanSocket.Power);
            return americanSocket;
        }
    }
}
