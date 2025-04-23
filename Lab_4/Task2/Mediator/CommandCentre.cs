using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Mediator
{
    public class CommandCentre : IMediator
    {
        private readonly List<Runway> _runways;

        public CommandCentre(List<Runway> runways)
        {
            _runways = runways;
        }

        public void RequestLanding(Aircraft aircraft)
        {
            var runway = _runways.FirstOrDefault(r => r.IsFree);

            if (runway != null)
            {
                Console.WriteLine($"Aircraft {aircraft.Name} has landed on Runway {runway.Id}.");
                runway.IsBusyWithAircraft = aircraft;
                runway.HighLightRed();
            }
            else
            {
                Console.WriteLine($"No free runway available for Aircraft {aircraft.Name}.");
            }
        }

        public void RequestTakeOff(Aircraft aircraft)
        {
            var runway = _runways.FirstOrDefault(r => r.IsBusyWithAircraft == aircraft);

            if (runway != null)
            {
                Console.WriteLine($"Aircraft {aircraft.Name} is taking off from Runway {runway.Id}.");
                runway.IsBusyWithAircraft = null;
                runway.HighLightGreen();
            }
            else
            {
                Console.WriteLine($"Aircraft {aircraft.Name} is not on any runway.");
            }
        }
    }

}
