using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            exercise1(); // Apply one formula
            exercise2(); // Is the given number prime?
            exercise3(); // List prime numbers between 2 and 10000
            Console.ReadLine();
        }
        //Apply one formula
        public static void exercise1()
        {
            Console.Write("\nEnter the side length of the square : ");
            int num = controlInputFunc(); //Input should be int, otherwise ask again
            Console.WriteLine("Perimeter : {0} , Area : {1}",num*4, num*num);
        }

        //Is the given number prime?
        public static void exercise2()
        {
            Console.WriteLine("\nIs the given number prime?");
            Console.Write("\nEnter the number : ");
            int num = controlInputFunc();  //Input should be int, otherwise ask again
            if(num == 1)
            {
                Console.WriteLine("{0} is not prime!", 1);
                return;
            }
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("{0} is not prime!", num);
                    return;
                }
            }
            Console.WriteLine("{0} is prime!", num);
        }
        //List prime numbers between 1 and 10000
        public static void exercise3()
        {
            Console.WriteLine("\nList prime numbers between 2 and 10000");

            for (int num = 2; num <= 10000; num++)
            {
                int control = 0;
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        control = 1;
                        break;
                    }
                }
                if (control == 0)
                {
                    Console.Write("{0} ", num);
                }
            }
        }

        //Input should be int, otherwise ask again
        public static int controlInputFunc(bool isZeroControl = false)
        {
            string tempStr = Console.ReadLine();
            //bool controlInput = Microsoft.VisualBasic.Information.IsNumeric(tempStr); //input should be int, otherwise ask the user again
            bool controlInput = int.TryParse(tempStr, out _);

            int num = 0;
            if (isZeroControl)
            {
                num = (controlInput == false || Convert.ToInt32(tempStr) == 0) ? takeInputAgain(isZeroControl) : Convert.ToInt32(tempStr);
            }
            else
            {
                num = (controlInput == false) ? takeInputAgain() : Convert.ToInt32(tempStr);
            }
            return num;
        }
        
        public static int takeInputAgain(bool isZeroControl = false)
        {
            string input;
            bool controlInput;
            while (true)
            {
                string message = (isZeroControl) ? "Please enter number different from 0 : " : "Please enter number : ";
                Console.Write(message);
                input = Console.ReadLine();
                //controlInput = Microsoft.VisualBasic.Information.IsNumeric(input);
                controlInput = int.TryParse(input, out _);
                if (controlInput)
                {
                    if ((isZeroControl && Convert.ToInt32(input) != 0) || !isZeroControl)
                    {
                        break;
                    }
                }
            }
            return Convert.ToInt32(input);
        }
    }
}
