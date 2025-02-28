using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal interface IReporting
    {
        void GenerateInventoryReport(IProductManager warehouse);
        void RegisterProductReceipt(IProductManager warehouse, string productName, int quantity, DateTime restockDate);
        void RegisterProductShipment(IProductManager warehouse, string productName, int quantity);
    }
}
