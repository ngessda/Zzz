using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static bool IsPrime(int n)
        {
            bool result = true;
            if (n <= 1) return false;
            for (int i = 2; i < n; i++) 
            {
                if (n % i == 0)
                {
                    result = false;
                    break;
                }
            }
            return result;
            // TODO
        }
        static void Main(string[] args)
        {
            Console.Write("Введие число для проверки: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(IsPrime(n));
        }
    }
}
