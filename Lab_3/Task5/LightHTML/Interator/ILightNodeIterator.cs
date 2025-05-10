using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.LightHTML.Iterator
{
    public interface ILightNodeIterator
    {
        bool HasNext();
        LightNode Next();
    }
}

