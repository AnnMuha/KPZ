using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Mediator
{
    public class Aircraft
    {
        public string Name { get; }
        private readonly IMediator _mediator;

        public Aircraft(string name, IMediator mediator)
        {
            Name = name;
            _mediator = mediator;
        }

        public void Land()
        {
            Console.WriteLine($"Aircraft {Name} is requesting to land...");
            _mediator.RequestLanding(this);
        }

        public void TakeOff()
        {
            Console.WriteLine($"Aircraft {Name} is requesting to take off...");
            _mediator.RequestTakeOff(this);
        }
    }
}
