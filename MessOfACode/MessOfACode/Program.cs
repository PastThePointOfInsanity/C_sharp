using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessOfACode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два числа через запятую");
            var input = Console.ReadLine();
            var numbers = input.Split(',');

            foreach (var s in numbers)
            {
                int result = 0;
                if (!int.TryParse(s, out result))
                {
                    Console.WriteLine("Ошибка, введите число");
                }

                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
    }
}
