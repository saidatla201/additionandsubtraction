using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace typesofvariables
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            {  
                // addition of two numbers
                Console.WriteLine("enter the number");
                int firstnumber, secondnumber, result;
                firstnumber = Convert.ToInt32(Console.ReadLine());
                secondnumber = Convert.ToInt32(Console.ReadLine());
                result = Convert.ToInt32(firstnumber + secondnumber);
                Console.WriteLine("the result is :" + result);
                Console.ReadLine();
            }

            //subtraction of two numbers
            {
                Console.WriteLine("enter the number");
                int a,b,c;
                a= Convert.ToInt32(Console.ReadLine());
                b= Convert.ToInt32(Console.ReadLine());
                c= Convert.ToInt32(a -b);
                Console.WriteLine("the result is :" + c);
                Console.ReadLine();
            }

            {
                // multiplication of two numbers
                Console.WriteLine("enter the number");
                int a, b, c;
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = Convert.ToInt32(a*b); 
                Console.WriteLine("the result is :" + c);
                Console.ReadLine();
            }


        }
    }
}

