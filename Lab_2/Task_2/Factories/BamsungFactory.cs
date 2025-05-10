using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2.Interfaces;
using Task_2.Products.Bamsung;

namespace Task_2.Factories
{
    public class BamsungFactory : ITechFactory
    {
        public ILaptop CreateLaptop() => new BamsungLaptop();
        public ITablet CreateTablet() => new BamsungTablet();
        public IEReader CreateEReader() => new BamsungEReader();
        public ISmartphone CreateSmartphone() => new BamsungPhone();
    }
}
