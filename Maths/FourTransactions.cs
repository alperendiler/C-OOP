using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maths
{
    internal class FourTransactions
    {
        public void Add(int number1,int number2)
        {
             double total = number1 + number2;
            Console.WriteLine(total);
        }
        public void Subtract(int number1,int number2) 
        {
            double total = number1 - number2;
            Console.WriteLine(total);

        }
        public void Divide(double number1, double number2)
        {
            double total = number1 / number2;
            Console.WriteLine(total);

        }
        public void Multiply(int number1, int number2)
        {
            double total = number1 * number2;
            Console.WriteLine(total);

        }











    }
}
