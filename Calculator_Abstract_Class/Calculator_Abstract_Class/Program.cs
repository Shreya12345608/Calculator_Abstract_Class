using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Abstract_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Message for Calculator Abstract Class");
            Division division = new Division();
            division.Multiply(25, 5);
            division.Divibile(500, 10);
            Console.ReadKey();
        }
    }
}
