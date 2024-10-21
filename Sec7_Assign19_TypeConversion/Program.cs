using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sec7_Assign19_TypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte a = 10; //Convert this value into "short" type (assign into another short type of variable)
            short newA = a; // byte is smaller than short
            System.Console.WriteLine(newA + " is " + newA.GetType());

            int b = 10; //Convert this value into "short" type (assign into another short type of variable)
            short newB = (short)b; //int is bigger than sort
            System.Console.WriteLine(newB + " is " + newB.GetType());

            string c = "10.34"; //Convert this value into "double" type using Parse  //Also, convert the same value into "decimal" type  using TryParse
            double newC = double.Parse(c);
            System.Console.WriteLine(newC + " is " + newC.GetType());

            bool checkParse = decimal.TryParse(c, out decimal newCC);
            System.Console.WriteLine("TryParse result is: " + checkParse + ". " + newCC + " is " + newCC.GetType());

            decimal d = 20.3m; //Convert this value into "string" type (assign into another string type of variable)
            string newD = Convert.ToString(d);
            System.Console.WriteLine(newD + " is " + newD.GetType());

            System.Console.ReadKey();
        }
    }
}
