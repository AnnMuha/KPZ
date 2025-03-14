using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public sealed class Authenticator
    {
        private static Authenticator _instance;

        private static readonly object _lock = new object();

        private Authenticator() { }

        // Метод для отримання єдиного екземпляра класу
        public static Authenticator GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Authenticator();
                    }
                }
            }
            return _instance;
        }

        // Метод для імітації авторизації
        public void AuthenticateUser()
        {
            Console.WriteLine("Користувач успішно авторизований!");
        }
    }
}
