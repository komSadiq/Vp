using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VpAsgmntOne
{


    class Program
    {
        static void Main(string[] args)
        {
            DateTime bDayDate;
            TimeSpan difference;
            int tDays;
            int years;
            int months;
            int days;
            int siblings;
            ArrayList siblingAges = new ArrayList();
            Console.WriteLine("Enter Number of siblings");
            siblings = int.Parse(Console.ReadLine());
            int[] ary = new int[siblings];
            DateTime[] sibAges = new DateTime[siblings];
            Console.WriteLine("------------------------------------------------------------------------");

            for (int i = 1; i <= ary.Length; i++)
            {
                Console.WriteLine("Enter date of birth of sibling " + i);
                bDayDate = DateTime.Parse(Console.ReadLine());
                siblingAges.Add(bDayDate);
                difference = DateTime.Now - bDayDate;
                tDays = (int)difference.TotalDays;
             
                if (DateTime.Now == bDayDate)
                {
                    Console.WriteLine("Age of sibling " + i + " is" + DateTime.Now);
                }

                else if (DateTime.Now.Year > bDayDate.Year)
                {
                    int DaysInBdayMonth = DateTime.DaysInMonth(bDayDate.Year, bDayDate.Month);
                    int DaysRemain = DateTime.Now.Day + (DaysInBdayMonth - bDayDate.Day);
                    years = tDays / 365;
                    months = tDays % 365;
                    months = months / 30;
                    days = (DaysRemain % DaysInBdayMonth + DaysInBdayMonth) % DaysInBdayMonth;
                    DateTime dtCombined = new DateTime(years, months, days);
                    sibAges[i] = bDayDate;
                    Console.WriteLine("Age of sibling " + i + " is  " + years + " years , " + months + "  months and " + days + "days");

                    // Console.WriteLine(dtCombined);
                }
                else if (bDayDate > DateTime.Now)
                {
                    Console.WriteLine("Birth day date cant be greater than current date");
                }

            }
            Console.WriteLine("------------------------------------------------------------------------");
            // Array.Sort(sibAges);
            siblingAges.Sort();
            for (int i = 0; i < siblingAges.Count; i++)
            {
                Console.WriteLine(siblingAges[i]);
                if (i + 1 < siblingAges.Count)
                {


                    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB");
                    DateTime pre = DateTime.Parse(siblingAges[i].ToString());
                    DateTime next = DateTime.Parse(siblingAges[i + 1].ToString());
                    difference = next - pre;
                    tDays = (int)difference.TotalDays;
                    int DaysInelderBdayMonth = DateTime.DaysInMonth(pre.Year, pre.Month);
                    int DaysRemain = next.Day + (DaysInelderBdayMonth - pre.Day);
                    years = tDays / 365;
                    months = tDays % 365;
                    months = months / 30;
                    days = (DaysRemain % DaysInelderBdayMonth + DaysInelderBdayMonth) % DaysInelderBdayMonth;

                    Console.WriteLine("Age of sibling " + i + " is " + years+"years" + " ," + months + "months"+" and" + days+"days");
                }
                else
                {
                    
                }   
            }
            Console.ReadLine();
        }
    }
}
