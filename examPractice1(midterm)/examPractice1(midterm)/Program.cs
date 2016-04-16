using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examPractice1_midterm_
{
    class Program
    {
        static void Main(string[] args)
        {
       //     String str1, str2;
            //str1 = "pakistan";
         //   str2 = "pakistan";
            // Console.WriteLine(str1.));
            //Student st;
            //Teacher tr;
            //Console.WriteLine(st.Equals(tr));
            Console.WriteLine("Hello World");
            Hello();
            Pakistan.Federal.Hello();
            Pakistan.Punjab.Lahore.Hello();
            Console.ReadLine();
        }
        static void Hello()
        {
            System.Console.WriteLine("Directly Called");
        }
    }
    namespace Pakistan
    {
        class Federal
        {
            public static void Hello()
            {
                System.Console.WriteLine("Hello Prime Minister!");
            }
        }
        //NESTED NAME SPACE or NAMESPACE HIERARCHY
        namespace Punjab
        {
            class Lahore
            {
                public static void Hello()
                {
                    System.Console.WriteLine("Kee Haal Paa Jee!");
                }
            }
            class Rawalpindi
            {
                public static void Hello()
                {
                    System.Console.WriteLine("Kay hall e Phapay!");
                }
            }
        }
    }
}


//        }
//    }
//    class Student
//    {
//        Student()
//        { }
//            public void method()
//            {
//                int obj= 13;
//                int xyz=24;
//                int value=76;
//            }

//        }
//    }
//    class Teacher
//    {
//        Teacher()
//        {

//        }
//        public void method2()
//        {
//            int x=32;
//            int y=34;
//            int z=35;
//        }


//    }

//}

