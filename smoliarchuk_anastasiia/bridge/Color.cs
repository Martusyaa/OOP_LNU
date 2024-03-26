namespace BridgePattern
{
    
    public interface IColor
    {
        string Paint();
    }

    
    public class Red : IColor
    {
        public string Paint()
        {
            return "Red";
        }
    }

   
    public class Blue : IColor
    {
        public string Paint()
        {
            return "Blue";
        }
    }

   
    public class Green : IColor
    {
        public string Paint()
        {
            return "Green";
        }
    }
 
    public class Yellow : IColor
    {
        public string Paint()
        {
            return "Yellow";
        }
    }
}
