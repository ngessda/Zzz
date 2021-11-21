using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введие число для проверки: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(zxc(n));
            bool zxc(int x)
            {
                if (n <= 2 || n % 2 == 0)
                {
                    return n == 2;
                }
                for (int i = 3; i < Math.Sqrt(n); i += 2)
                {
                    if (n % i == 0) { return false; }
                }
                return true;
            }
        }
    }
}
