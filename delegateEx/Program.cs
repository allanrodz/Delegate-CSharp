using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateEx
{
    delegate int Calculate(int num);
    class Program
    {
        static void Main(string[] args)
        {
            Calculate c1 = new Calculate(Add);
            //c1(10);
            Console.WriteLine("The Value is "+ c1(10));

            Calculate c2 = new Calculate(Multiply);
            //c1(10);
            Console.WriteLine("The Value is " + c2(10));
            Console.Read();

        }

        static int number = 25;

        public static int Add(int num)
        {
            number = number + num;
            return number;
          
        }

        public static int Multiply(int num)
        {
            number = number * num;
            return number;

        }


    }
}
