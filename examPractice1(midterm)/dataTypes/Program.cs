using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 11;
            int z = 12;
            Console.WriteLine(Sum(x, y, z));

        }
        public static int Sum(int x,int y, int z)
        {
            return x + y + z;
        }
    }
}
