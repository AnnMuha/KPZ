using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.LightHTML.Strategy
{
    public interface IImageLoadingStrategy
    {
        string LoadImage(string href);
    }
}
