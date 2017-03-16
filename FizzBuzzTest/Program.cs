using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz;

namespace FizzBuzzTest
{
    class Program
    {
        static void Main(string[] args)
        {

            IFizzBuzz fb = new FizzBuzz.FizzBuzz();
            Console.WriteLine($"Application has returned {fb.GetFizzBuzzData(3)} for 3");
            Console.WriteLine($"Application has returned {fb.GetFizzBuzzData(5)} for 5");
            Console.WriteLine($"Application has returned {fb.GetFizzBuzzData(15)} for 15");
            Console.ReadLine();
        } 
    }
}
