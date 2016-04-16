using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second_highest_no
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myarry = { 8, 9, 10, 3, 4, 1, 11, 6 };
            int largest=0;
            int secondLargest=0;
            foreach(int i in myarry)
            {
                if(i>largest)
                {
                    secondLargest = largest;
                    largest = i;
                }
                else if(i>secondLargest)
                {
                    secondLargest = i;
                }

            }
            Console.WriteLine("second largest number="+secondLargest);
            Console.WriteLine("largest number=" + largest);
            Console.ReadLine();
        }

    }
}
