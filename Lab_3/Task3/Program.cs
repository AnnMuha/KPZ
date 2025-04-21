using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.Rendering;
using Task3.Shapes;

namespace Task3
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("=== Графічний редактор ===\n");

            IRenderStrategy vector = new VectorRenderer();
            IRenderStrategy raster = new PixelRenderer();

            BaseShape[] vectorShapes = {
            new Circle(vector),
            new Square(vector),
            new Triangle(vector)
        };

            Console.WriteLine("Векторне рендерування:");
            foreach (var shape in vectorShapes)
                shape.Draw();

            BaseShape[] rasterShapes = {
            new Circle(raster),
            new Square(raster),
            new Triangle(raster)
        };

            Console.WriteLine("\nРастрове рендерування:");
            foreach (var shape in rasterShapes)
                shape.Draw();
        }
    }
}
