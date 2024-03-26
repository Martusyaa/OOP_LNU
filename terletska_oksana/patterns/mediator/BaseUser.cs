using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class BaseUser
{
    protected IChatMediator _mediator;
    public string Name { get; private set; }

    public BaseUser(string name, IChatMediator mediator)
    {
        this.Name = name;
        this._mediator = mediator;
    }

    public void Send(string message)
    {
        _mediator.SendMessage(message, this);
    }

    public abstract void Receive(string message);
}
