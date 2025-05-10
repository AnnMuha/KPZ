using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            var instance1 = Authenticator.GetInstance();
            var instance2 = Authenticator.GetInstance();

            // Перевірка, що обидва екземпляри однакові
            Console.WriteLine(ReferenceEquals(instance1, instance2)
                ? "Це один і той самий екземпляр!"
                : "Різні екземпляри!");

            instance1.AuthenticateUser();
        }
    }
}
