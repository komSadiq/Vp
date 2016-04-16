using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arry = new int[100];

            //for (int i = 1; i < 100; i++)
            //{
            //    if(i==27)
            //    { }
            //    else
            //        arry[i] = i;


            //}
            //for (int i = 1; i < 100; i++)
            //{
            //    if (arry[i] != i)
            //    {
            //        Console.WriteLine(i);
            //        break;
            //    }
            int n;
             Console.WriteLine("Enter sum of numbers");
             n = int.Parse(Console.ReadLine());
             Console.WriteLine(digitCount(n));
            // SumOfNumber(n);
            // //Duplicatenumber();
            //String str1;
            //Console.WriteLine("enter String1");
            //str1 = Console.ReadLine();

            //String str2;
            //Console.WriteLine("enter String2");
            //str2 = Console.ReadLine();
           // Console.WriteLine(wordCount(str1));
           //Console.WriteLine( Anagram(str1, str2));
           // longestplindrome(str);
            //if (str == Palindrom(str))
            //{
            //    Console.WriteLine("palindrome");
            //}
            //else
            //{
            //    Console.WriteLine("not palindrome");
            //}
           // NonRepeating(str);
            Console.ReadLine();

        }
        public static void SumOfNumber(int n)
        {
            int[] myarry = { 1, 2, 3, 5, 6, 7, 8, 9, 4, 11 };
            int firstNum = 0, secondNum = 0, Sum = n;
            for (int i = 0; i < myarry.Length; i++)
            {
                firstNum = myarry[i];
                for (int j = 0; j < myarry.Length; j++)
                {
                    secondNum = myarry[j];
                    if (firstNum + secondNum == Sum)
                    {
                        Console.WriteLine("{" + firstNum + "," + secondNum + "}");
                    }

                }
            }
        }
        public static void Duplicatenumber()
        {
            int[] myarry = { 1, 4, 5, 2, 6, 2, 7, 1, 9, 0, 5, 6, 7 };
            try
            {
                //for (int i = 0; i < myarry.Length; i++)
                //{
                //    myarry[i] = i;
                //}
                int a =0;
                Array.Sort(myarry);
                // List<int> tmp = new List<int>(myarry);
                for (int j = 0; j < myarry.Length-1; j++)
                {
                    if (j != myarry.Length)
                    {
                        if (myarry[j] == myarry[j + 1])
                        {
                            a = myarry[j];
                            //Console.WriteLine(myarry[j]);
                            //break;
                            myarry.Except(new int[]{myarry[j]}).ToArray();
                            
                            break;
                        }   
                    }
                        
                }
                Console.WriteLine(myarry[a]);
               

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
        public static string Palindrom(String str1)
        {
           // Boolean isPalindrom;
            
          //  if (str1.Equals(reverse(str2))==true);
            char[]palindrom=str1.ToCharArray();
           

            Array.Reverse(palindrom);
            return new string(palindrom);
			
           
        }
        public static void NonRepeating(String str)
    {
        char[] arry = str.ToCharArray();
       
            for (int i=0; i<str.Length;i++)
            {
                if(str.IndexOf(arry[i])==str.LastIndexOf(arry[i]))
                {
                    Console.WriteLine( arry[i] );
                    break;
                }
            }
            
    }
        public static void longestplindrome(String str)
        {
            String output= "";
            int minLength = 3;
            for (int i=0;i<str.Length - minLength;i++)
            {
                for(int j=minLength+i;j<str.Length - minLength;j++)
                {
                    String forward = str.Substring(i, j - i);
                    String reverse = new String (str.Reverse().ToArray());
                    if ((forward == reverse) && (forward.Length  >  minLength))
                    {
                        output = forward;
                        minLength = forward.Length;
                    }
                
                    }
            }
            Console.WriteLine(output);


        }
        public static bool Anagram(String str1, String str2)
        {
            char[] charArray1 = str1.ToCharArray();
            Array.Sort(charArray1);

            char[] charArray2 = str2.ToCharArray();
            Array.Sort(charArray2);

            if((new String(charArray1))==(new String (charArray2)))
            {
                return true;

            }
            else
            {
                return false;
            }

        }
        public static int wordCount(String str)
        {
            int count = 0;
            char[] chArray = str.ToCharArray();
            foreach(char ch in chArray)
            {
                if((Char.IsPunctuation(ch))||(Char.IsWhiteSpace(ch)))
                {
                    count++;
                }
                else
                {

                }
            }
            return count;
        }
        public static int digitCount(int numb)
        {
            String NoinString = numb.ToString();
            int Count = NoinString.Length;
            return Count; 

        }
        
    }