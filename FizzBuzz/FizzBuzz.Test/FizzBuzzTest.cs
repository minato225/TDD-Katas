using NUnit.Framework;
using System.Linq;

namespace FizzBuzzKata.Test
{
    [TestFixture]
    public class FizzBuzzTest
    {
        private const string Expected = "1\n2\nFizz\n4\nBuzz\nFizz\n7\n8\nFizz\nBuzz\n11\nFizz\n13\n14\nBuzz" +
                                        "\n16\n17\nFizz\n19\nBuzz\nFizz\n22\n23\nFizz\nBuzz\n26\nFizz\n28\n29" +
                                        "\nBuzz\n31\n32\nFizz\n34\nBuzz\nFizz\n37\n38\nFizz\nBuzz\n41\nFizz\n" +
                                        "43\n44\nBuzz\n46\n47\nFizz\n49\nBuzz\nFizz\n52\n53\nFizz\nBuzz\n56\n" +
                                        "Fizz\n58\n59\nBuzz\n61\n62\nFizz\n64\nBuzz\nFizz\n67\n68\nFizz\nBuzz" +
                                        "\n71\nFizz\n73\n74\nBuzz\n76\n77\nFizz\n79\nBuzz\nFizz\n82\n83\nFizz" +
                                        "\nBuzz\n86\nFizz\n88\n89\nBuzz\n91\n92\nFizz\n94\nBuzz\nFizz\n97\n98" +
                                        "\nFizz\nBuzz\n"; 
        
        [Test]
        public void Check_for_Divisible_3()
        {
            var result = FizzBuzzClass.FizzBuzz();
            
            Assert.AreEqual(Expected, result);
        }
    }
}
