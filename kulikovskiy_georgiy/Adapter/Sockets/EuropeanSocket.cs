namespace Adapter
{
    public class EuropeanSocket
    {
        public string Power { get; set; }

        public EuropeanSocket(string power)
        {
            Power = power;
        }

        public override string ToString()
        {
            return "European socket";
        }
    }
}
