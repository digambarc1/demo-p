using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegatess
{
     class Program
     {
        //<modifier> delegate  ReturnType delegatename()
        public delegate void somedelegate();
        public static somedelegate someobj = null;

        static void Main(string[] args)
        {

            someobj = Fun1;
            someobj.Invoke();
        }

        static void Fun1()
        {
            Console.WriteLine("Hello World");
        }
     }
}
