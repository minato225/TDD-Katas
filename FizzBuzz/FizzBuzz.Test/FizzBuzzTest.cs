using NUnit.Framework;
using System.Linq;

namespace FizzBuzzKata.Test
{
    [TestFixture]
    public class FizzBuzzTest
    {
        [Test]
        public void Print_numbers_from_1_to_100()
        {
            var result = FizzBuzzClass.PrintHundred();
            var expected = string.Join("\n", Enumerable.Range(1, 100));
            
            Assert.AreEqual(result, expected);
        }
    }
}
