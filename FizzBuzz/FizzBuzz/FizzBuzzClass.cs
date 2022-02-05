using System.Text;

namespace FizzBuzzKata
{
    public static class FizzBuzzClass
    {
        public static string PrintHundred()
        {
            var hundred = new StringBuilder();
            for (var i = 1; i <= 100; i++)
                hundred.Append(i).Append('\n');
            
            return hundred.ToString();
        }
    }
}