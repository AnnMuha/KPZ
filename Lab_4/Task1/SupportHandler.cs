using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public abstract class SupportHandler
    {
        protected SupportHandler _next;

        public SupportHandler SetNext(SupportHandler next)
        {
            _next = next;
            return next;
        }

        public abstract void ProcessRequest();
    }
}
