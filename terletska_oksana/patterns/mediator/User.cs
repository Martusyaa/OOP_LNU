using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class User : BaseUser
{
    public User(string name, IChatMediator mediator) : base(name, mediator) { }

    public override void Receive(string message)
    {
        Console.WriteLine($"{Name} received a message: {message}");
    }
}
