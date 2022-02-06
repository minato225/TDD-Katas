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
                var isThird = i % 3 == 0; 
                var isFifth = i % 5 == 0;
                
                if (isThird)
                {
                    hundred.Append("Fizz");
                }
                
                if (isFifth)
                {
                    hundred.Append("Buzz");
                }
                
                if(!isFifth && !isThird)
                {
                    hundred.Append(i);
                }

                hundred.Append('\n');
            }

            return hundred.ToString();
        }
    }
}