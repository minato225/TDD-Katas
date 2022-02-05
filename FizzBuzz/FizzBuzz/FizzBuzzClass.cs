using System;
using System.IO;
using System.Text;

namespace FizzBuzzKata
{
    public static class FizzBuzzClass
    {
        public static string FizzBuzz()
        {
            var hundred = new StringBuilder();
            for (var i = 1; i <= 100; i++)
            {
                if (i % 5 == 0)
                {
                    hundred.Append("Buzz");
                }
                else if (i % 3 == 0)
                {
                    hundred.Append("Fizz");
                }
                else
                {
                    hundred.Append(i);
                }

                hundred.Append('\n');
            }

            return hundred.ToString();
        }
    }
}