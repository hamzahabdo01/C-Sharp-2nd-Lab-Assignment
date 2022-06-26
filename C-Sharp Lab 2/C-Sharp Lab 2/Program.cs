using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lab_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Even and Odd Number Program

            int num;
            Console.WriteLine("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num >= 0)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("The number you entered is an even number.");
                }
                else
                {
                    Console.WriteLine("The number you entered is an odd number.");
                }
            }
            else
            {
                Console.WriteLine("The number you entered can't be evaluated as an odd or even number.");
            }

            //A program that accepts integer number any number of times we want and multiply them

            int num1,numoftimes,product=1;
            Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("Enter a number, then enter the number of times you want to multiply this number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            numoftimes = Convert.ToInt32(Console.ReadLine());
            if (numoftimes == 0)
            {
                Console.WriteLine("Your number is: " + num1);
            }
            else if(numoftimes > 0)
            {
                for(int i = 1; i < numoftimes+1; i++)
                {
                    product = (num1*num1)*i;
                }
                Console.WriteLine("Your number is: "+product);
            }
            else
            {
                Console.WriteLine("The number of times you entered is invalid.");
            }

            Console.ReadKey();

        }
    }
}
