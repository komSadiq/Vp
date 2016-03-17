using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vpClassAssigment1
{

    class Program
    {
        static void Main(string[] args)
        {
            string noOfSibbling,dateOfBirth;
            int no;
            DateTime date,now;
            //DateTime[] sibling;

            now = DateTime.Now;

            Console.WriteLine("enter no of siblings: ");
            noOfSibbling = Console.ReadLine();
            no = Int32.Parse(noOfSibbling);
            for (int i = 1; i <= no; i++)
            {
                Console.WriteLine("Enter Date of Birth of Sibling" + i+":");
                dateOfBirth = Console.ReadLine();
               
                date = Convert.ToDateTime(dateOfBirth);
              // sibling[i] = date;
               Console.WriteLine("your age is: ");
                Console.WriteLine(calculateAge(date,now));
                //Console.WriteLine(date.Year, date.Month, date.Day);
               // Console.WriteLine("Year: {0}, Month: {1}, Day: {2}", date.Year, date.Month, date.Day);
               Console.WriteLine(date);
                DateTime difference = date.Now - date.dateOfBirth;
                
               // DateTime ageOfperson = Convert.ToDateTime(age);
                //Console.WriteLine(" yoyr age is "+ "Year: {0}, Month: {1}, Day: {2}", ageOfperson.Year,ageOfperson.Month,ageOfperson.Day);
               


            }
           
                
                //Console.WriteLine("enter date of first../'dd-mm-yyyy'");
                //d1= Console.ReadLine();

                //TimeSpan t;

                //double NrOfDays = t.TotalDays;


                Console.ReadLine();
        }
      public static string calculateAge(DateTime birthDate, DateTime now)
        {
            //BDay is in different year (age > 1)
            int age = now.Year - birthDate.Year;
            if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day)) 
                    age--;

            if (age == 0)
            {
                //Bday is in same year
                age = now.Month - birthDate.Month;
                if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day)) age--;

                return age.ToString() + " months";
            }
            if (age == 0)
            {
                //Bday is in the same month
                age = now.Day - birthDate.Day;
                if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day)) age--;

                return age.ToString() + " days";
            }
            return age.ToString();
        }
    }
}
