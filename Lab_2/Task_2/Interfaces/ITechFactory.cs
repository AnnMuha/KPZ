using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Interfaces
{
    public interface ITechFactory
    {
        ILaptop CreateLaptop();
        ITablet CreateTablet();
        IEReader CreateEReader();
        ISmartphone CreateSmartphone();
    }
}
