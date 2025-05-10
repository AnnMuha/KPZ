using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Mediator
{
    public class Runway
    {
        public Guid Id { get; } = Guid.NewGuid();
        public Aircraft IsBusyWithAircraft { get; set; }

        public bool IsFree => IsBusyWithAircraft == null;

        public void HighLightRed()
        {
            Console.WriteLine($"Runway {Id} is busy!");
        }

        public void HighLightGreen()
        {
            Console.WriteLine($"Runway {Id} is free!");
        }
    }
}
