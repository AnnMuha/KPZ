using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Rendering
{
    public class PixelRenderer : IRenderStrategy
    {
        public void Render(string shapeName)
        {
            Console.WriteLine($"Малюємо {shapeName} як пікселі (растрова графіка)");
        }
    }
}
