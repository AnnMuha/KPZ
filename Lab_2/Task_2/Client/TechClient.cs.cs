using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2.Interfaces;

namespace Task_2.Client
{
    public class TechClient
    {
        private ILaptop _laptop;
        private ITablet _tablet;
        private IEReader _eReader;
        private ISmartphone _smartphone;

        public TechClient(ITechFactory factory)
        {
            _laptop = factory.CreateLaptop();
            _tablet = factory.CreateTablet();
            _eReader = factory.CreateEReader();
            _smartphone = factory.CreateSmartphone();
        }

        public void Run()
        {
            _laptop.ShowInfo();
            _tablet.ShowInfo();
            _eReader.ShowInfo();
            _smartphone.ShowInfo();
        }
    }
}
