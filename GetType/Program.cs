using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetType
{
    class Program
    {
        static void Main(string[] args)
        {
            string aStringValue = "01/01/2012";
            object obj = (object) aStringValue;
            Console.WriteLine(obj.GetType().ToString());
            Console.ReadLine();
        }
    }
}
