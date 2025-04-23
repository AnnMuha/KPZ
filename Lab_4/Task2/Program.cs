using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Mediator;

namespace Task2
{
     class Program
    {
        static void Main(string[] args)
        {
            var runways = new List<Runway> { new Runway(), new Runway() };
            var commandCentre = new CommandCentre(runways);

            var aircraft1 = new Aircraft("Boeing 737", commandCentre);
            var aircraft2 = new Aircraft("Airbus A320", commandCentre);

            aircraft1.Land();
            aircraft2.Land();
            aircraft1.TakeOff();
            aircraft2.TakeOff();
        }
    }
}
