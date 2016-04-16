using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPractice2_midterm_
{
    class Program
    {
        static void Main(string[] args)
        {
           // int[] arry = {2,3,7,8,3,1,7};
           // for(int x=0;x<7;x++)
           //// {Console.WriteLine(arry[x]);}
           
           // Array.Sort(arry);
           // for (int y = 0; y < 7; y++)
           // { Console.WriteLine(arry[y])}
           // string str = "my name is komal";
           // string str1;
           // Console.WriteLine(str+"\n");
           // char[] myarry = str.ToCharArray();
        //    //Char[] reverseArray=null;
            //Swap(myarry, 0, 1);
            //try
            //{
            //    for (int i = myarry.Length; i > 0; i--){
            //        for (int j = 0; j < reverseArray.Length;j++ )
            //        {
            //            reverseArray[j]=myarry[i];
            //        }
            //    }
            //    for(int k=0;k<reverseArray.Length;k++)
            //    {
            //        Console.WriteLine(reverseArray[k]);
            //    }
            //}catch(Exception e)
            //{
            //    Console.WriteLine(e.ToString());
            //}
                //  int input,pow;
                // // Char loop;
                //// do{
                //  try
                //  {
                //      Console.WriteLine("Enter input: ");
                //      input = Int32.Parse(Console.ReadLine());
                //      // EvenOdd(input);
                //      unchecked
                //      {
                //          Console.WriteLine("Enter power: ");
                //          pow = Int32.Parse(Console.ReadLine());
                //          Console.WriteLine(power(input, pow));
                //      }
                //      // Console.WriteLine("press y to Continue");
                //      //loop = char(Console.Read());
                //      //}while(loop!='y');

            int? x = null;
            int y;
            Console.WriteLine(sizeof(double));
           Console.WriteLine( y = x??0);

                //  }
                //  catch (Exception e)
                //  {
                //      Console.WriteLine(e.ToString());
                //  }
                Console.ReadLine();
        }
        //public static void EvenOdd(int x)
        //{
        //    if(x%2==0)
        //    {
        //        Console.WriteLine("input is even");

        //    }
        //    else if(x%2!=0)
        //    {
        //        Console.WriteLine("input is odd");
                
        //    }
        //    else
        //    {
        //        Console.WriteLine("NOt even not Odd");

        //    }
        public static long power(int number,int pow)
        {
            long result=1;
            for(int i=1; i<=pow;i++)
            {
                result=result*number;
            }
            return result;
        }

        }
    }

