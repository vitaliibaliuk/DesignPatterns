using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.task3
{
    public class Circle : Shape
    {
        public Circle(ITypeDrawing impl) : base(impl) { }

        public override void Dwaw()
        {
            _impl.DrawCircle();
        }
    }
}
