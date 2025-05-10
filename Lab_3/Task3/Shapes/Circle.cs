using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.Rendering;

namespace Task3.Shapes
{
    public class Circle : BaseShape
    {
        public Circle(IRenderStrategy renderer) : base(renderer) { }

        public override void Draw()
        {
            renderer.Render("Коло");
        }
    }
}
