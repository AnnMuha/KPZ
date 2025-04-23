using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;
using Task1.Levels;

namespace Task1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Створюємо об'єкти підтримки
            var tariff = new TariffSupport();
            var payment = new PaymentSupport();
            var tech = new TechnicalSupport();
            var general = new GeneralSupport();

            // Встановлюємо ланцюжок
            tariff.SetNext(payment).SetNext(tech).SetNext(general);

            // Запуск
            tariff.ProcessRequest();
        }
    }
}
