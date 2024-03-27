namespace Adapter
{
    public class AmericanSocket
    {
        public string Power { get; set; }

        public AmericanSocket(string power)
        {
            Power = power;
        }

        public override string ToString()
        {
            return "American socket";
        }
    }
}
