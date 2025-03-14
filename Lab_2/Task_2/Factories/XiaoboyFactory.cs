using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2.Interfaces;
using Task_2.Products.Xiaoboy;

namespace Task_2.Factories
{
    public class XiaoboyFactory : ITechFactory
    {
        public ILaptop CreateLaptop() => new XiaoboyLaptop();
        public ITablet CreateTablet() => new XiaoboyTablet();
        public IEReader CreateEReader() => new XiaoboyEReader();
        public ISmartphone CreateSmartphone() => new XiaoboyPhone();
    }
}
