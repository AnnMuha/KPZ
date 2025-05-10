using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2.Interfaces;

namespace Task_2.Products.Macrosoft
{
    public class MacrosoftLaptop : ILaptop
    {
        public void ShowInfo() => Console.WriteLine("Ноутбук Macrosoft створено");
    }
}
