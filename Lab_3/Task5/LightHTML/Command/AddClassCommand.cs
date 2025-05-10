using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5.LightHTML;

namespace Task5.LightHTML.Command
{
    public class AddClassCommand : ICommand
    {
        private readonly LightElement _element;
        private readonly string _className;

        public AddClassCommand(LightElement element, string className)
        {
            _element = element;
            _className = className;
        }

        public void Execute()
        {
            _element.AddClass(_className);
        }

        public void Undo()
        {
            _element.CssClasses.Remove(_className);
        }
    }
}

