using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IChatMediator
{
    void SendMessage(string message, BaseUser user);
}

public class ChatMediator : IChatMediator
{
    public void SendMessage(string message, BaseUser user)
    {
        Console.WriteLine($"{user.Name} sent a message: {message}");
        user.Receive(message);
    }
}
