using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2.Interfaces;
using Task_2.Products.Macrosoft;

namespace Task_2.Factories
{
    public class MacrosoftFactory : ITechFactory
    {
        public ILaptop CreateLaptop() => new MacrosoftLaptop();
        public ITablet CreateTablet() => new MacrosoftTablet();
        public IEReader CreateEReader() => new MacrosoftEReader();
        public ISmartphone CreateSmartphone() => new MacrosoftPhone();
    }
}
