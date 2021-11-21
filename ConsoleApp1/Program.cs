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
            bool result = false;
            int[] arr = new int[4] { 2, 3, 5, 7 };
            if (n <= 1)
            {
                return result;
            }
            if (n == 2 || n == 3 || n == 5 || n == 7)
            {
                result = true;
                return result;
            }
            for (int i = 1; i < 4; i++)
            {
                if (n % arr[i] == 0)
                {
                    return result;
                }
            }
            result = true;
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
