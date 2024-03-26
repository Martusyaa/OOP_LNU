using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        IChatMediator mediator = new ChatMediator();

        BaseUser user1 = new User("User1", mediator);
        BaseUser user2 = new User("User2", mediator);
        BaseUser user3 = new User("User3", mediator);

        user1.Send("Hi");
        Console.WriteLine();

        user2.Send("Hello");
    }
}
