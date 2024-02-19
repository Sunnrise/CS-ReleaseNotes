using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypePattern
{
    class TypePattern
    {
        static void Main(string[] args)
        {

            #region var pattern and var type difference
            object z ="imSunnrise";
            var a = "sun";//var keyword turns variable when compiling the code
            if (z is var b)//var pattern turns variable when the code is running
            {
                Console.WriteLine($"z is a {b.GetType().Name} and its value is {b}");
            }
            
            #endregion
            

            
            Console.ReadKey();
        }
    }
}