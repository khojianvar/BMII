using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lesson_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            /*// first task
            Console.Write("Enter the firstnumber: ");
            int firstnumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the secondnumber: ");
            int secondnumber = int.Parse(Console.ReadLine());
            if(firstnumber!=secondnumber)
            {
                Console.WriteLine($"Result: {firstnumber} + {secondnumber} = {firstnumber + secondnumber}");
            }else if(secondnumber==firstnumber) 
            {
                Console.WriteLine($"Result: ({firstnumber} + {secondnumber}) * 3 = {(firstnumber + secondnumber) * 3}");
            }*/

            Console.Write("Enter your weight: ");
            float weiht = float.Parse(Console.ReadLine());
            Console.Write("Enter your height: ");
            float height = float.Parse(Console.ReadLine());
            float res = (weiht / (height * height)) * 10000;
            Console.WriteLine($"BMI:{Math.Round(res, 1, MidpointRounding.AwayFromZero)} m/h^2");

            Main(args);
        }


   }
}