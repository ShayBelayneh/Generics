using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Generics<T>
    {
        public string color;
        public T legs;

        public Generics(string color, T legs)
        {
            this.color = color;
            this.legs = legs;
        }

        public T Legs { get; set; }
        public T Color { get; set; }
    }

}




