using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Chair<T>

    {

        public T height;
        public T legs;


        public Chair(T height, T legs)
        {

            this.height = height;
            this.legs = legs;

        }
        public T Height { get; set; }
        public T Legs { get; set; }



    }
}
