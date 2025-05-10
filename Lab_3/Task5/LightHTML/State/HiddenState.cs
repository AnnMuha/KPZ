using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.LightHTML.State
{
    public class HiddenState : IVisibilityState
    {
        public void SetState(VisibilityContext context)
        {
            context.CurrentState = this;
        }

        public bool IsVisible()
        {
            return false;
        }
    }
}

