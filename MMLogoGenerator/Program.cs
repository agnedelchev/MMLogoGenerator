using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMLogoGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            bool parseCheck;
            Console.Write("Enter number N. The number must be an odd integer between 2 and 10000: ");
            string input = Console.ReadLine();
            parseCheck = int.TryParse(input, out n);
            while (parseCheck == false || n % 2 == 0 || n < 2 || n > 10000)
            {
                Console.Write("Invalid input entered. Input must be an odd integer between 2 and 10000: ");
                input = Console.ReadLine();
                parseCheck = int.TryParse(input, out n);
            }
            LogoGeneratorClass result = new LogoGeneratorClass(n);
            Console.WriteLine(result.ResultLogo());
        }
    }
}
