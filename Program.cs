using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Cesar Roncancio
//CISS201
//Agile Development
//9/27/2020
namespace dropbox06
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 5;
            //call the Multiply() method and store the retunr value in total
            int total = Multiply(a, b);
            Console.WriteLine("The multiplication of {0} and {1} is {2}", a, b, total);
            Console.ReadKey();
        }
        //Multiply() method
        static int Multiply(int x, int y)
        {
            int mult;
            mult = x * y;
            return mult;
        }
    }
}
