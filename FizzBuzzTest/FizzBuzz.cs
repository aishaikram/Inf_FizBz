using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{


    /// <summary>
    /// FizzBuzz Business Logic 
    /// </summary>
    public class FizzBuzz : IFizzBuzz, IDisposable
    {

        /// <summary>
        /// Returns the FizzBuzz Data
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public string GetFizzBuzzData(int num)
        {
            return (num%15 == 0) ? "FIZZBUZZ" : (num%3 == 0) ? "FIZZ" : (num%5 == 0) ? "BUZZ" : num.ToString();
        }

        public void Dispose()
        {
            // Cleanup if any. None currently
        }
    }
}
