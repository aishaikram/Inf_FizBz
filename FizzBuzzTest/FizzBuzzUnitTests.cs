using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace FizzBuzz
{

    [TestFixture]
    class FizzBuzzUnitTests
    {

        #region "Private Member"
        private static string _fizzResult = "FIZZ";
        private static string _buzzResult = "BUZZ";
        private static string _fizzbuzzResult = "FIZZBUZZ";
        private static int _one = 1;
        private static FizzBuzz _fizzBuzzer;
        private static FizzBuzzMocker _mock;
        #endregion

        #region "Setup"
        [SetUp]
        public void Init()
        {
            _fizzBuzzer = new FizzBuzz();
            _mock = new FizzBuzzMocker();
        }

        #endregion

        #region "Tests"


        [Test]
        public void should_Return_Original_Number()
        {
            String fizzResult = _fizzBuzzer.GetFizzBuzzData(_one);
            Assert.AreEqual("1", fizzResult);
        }

        [Test]
         public void should_Return_NotNull_Result()
        {
            String fizzResult = _fizzBuzzer.GetFizzBuzzData(_one);
            Assert.AreNotEqual(null, fizzResult);
        }


        [Test]
        public void should_Return_Fizz_For_Multiple_Of_Three()
        {
            // Run the data for 10 random numbers resulting Fizz
            for (int i = 0; i < 10; i++)
            {
                int num = _mock.GetRandomNumberForResult_Fizz();
                String fizzResult = _fizzBuzzer.GetFizzBuzzData(num);
                Assert.AreEqual(_fizzResult, fizzResult);
            }
        }

        [Test]
        public void should_Return_Buzz_For_Multiple_Of_Five()
        {
            // Run the data for 10 random numbers resulting Buzz
            for (int i = 0; i < 10; i++)
            {
                int num = _mock.GetRandomNumberForResult_Buzz();
                String bResult = _fizzBuzzer.GetFizzBuzzData(num);
                Assert.AreEqual(_buzzResult, bResult);
            }
        }

        [Test]
        public void should_Return_FizzBuzz_For_Multiple_Of_Five_And_Three()
        {
            // Run the data for 10 random numbers resulting FizzBuzz
            for (int i = 0; i < 10; i++)
            {
                int num = _mock.GetRandomNumberForResult_FizzBuzz();
                String fbResult = _fizzBuzzer.GetFizzBuzzData(num);
                Assert.AreEqual(_fizzbuzzResult, fbResult);
            }
        }

        #endregion
    }

    #region "FizzBuzz Mocker"
    /// <summary>
    /// The mocker class returns the mock data for testing FizzBuzz class
    /// </summary>
    public class FizzBuzzMocker
    {

        public int GetRandomNumberForResult_FizzBuzz()
        {
            // Return multiple of 15
            Random r = new Random();
            int num = r.Next(5000);
            return 15*num;
        }

        public int GetRandomNumberForResult_Fizz()
        {
            // Return multiple of 3 but not multiple of 5
            Random r = new Random();
            int num = r.Next(5000) * 3;
            while ((num % 5) == 0)
            { num = r.Next(5000) * 3; }

            return num;

        }

        public int GetRandomNumberForResult_Buzz()
        {
            // Return multiple of 5 but not multiple of 3
            Random r = new Random();
            int num = r.Next(5000) * 5;
            while ((num % 3) == 0)
            { num = r.Next(5000) * 5; }

            return num;
        }

    }
    #endregion


}
