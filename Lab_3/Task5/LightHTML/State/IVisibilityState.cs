using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.LightHTML.State
{
    public interface IVisibilityState
    {
        void SetState(VisibilityContext context);
        bool IsVisible();
    }
}

