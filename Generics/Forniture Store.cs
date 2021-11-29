using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class forniture_store<T>
    {

        public T numberdesk;
        public T numberchair;
        public T numberboard;
        public List<T> sizeList;


        public forniture_store(T numberdesk, T numberchair, T numberboard, List<T> _sizeList)
        {

            this.numberdesk = numberdesk;
            this.numberchair = numberchair;
            this.numberboard = numberboard;
            this.sizeList = _sizeList;

        }


    }
}
