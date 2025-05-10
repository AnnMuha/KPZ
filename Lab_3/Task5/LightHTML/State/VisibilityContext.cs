using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.LightHTML.State
{
    public class VisibilityContext
    {
        public IVisibilityState CurrentState { get; set; }

        public VisibilityContext()
        {
            CurrentState = new VisibleState();
        }

        public void SetState(IVisibilityState state)
        {
            state.SetState(this);
        }

        public bool IsVisible()
        {
            return CurrentState.IsVisible();
        }
    }
}
