using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.Rendering;

namespace Task3.Shapes
{
    public abstract class BaseShape
    {
        protected IRenderStrategy renderer;

        public BaseShape(IRenderStrategy renderer)
        {
            this.renderer = renderer;
        }

        public abstract void Draw();
    }
}
