using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Abstract_Class
{
        abstract class Calculate
        {
           public abstract void Multiply(int FirstNumber, int SecondNumber);
        }

        abstract class Multiplication : Calculate
    {

            public override void Multiply(int FirstNumber, int SecondNumber)
            {
                int Output = FirstNumber * SecondNumber;
                Console.WriteLine("Calling Abstract  from Calculator class");
                Console.WriteLine("Multiplication of " + FirstNumber +" * " + SecondNumber +  " = " + Output);
            }

            public abstract void Divibile(int FirstNumber, int SecondNumber);
        }

        class Division : Multiplication
        {
            public override void Divibile(int FirstNumber, int SecondNumber)
            {
                int Output = FirstNumber / SecondNumber;
                Console.WriteLine(" Calling Abstract from Multiplication class");
                Console.WriteLine($"Division of " + FirstNumber + " / " + SecondNumber + " = " + Output);
            }
        }
    }

