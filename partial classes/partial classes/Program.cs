using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partial_classes
{

    public partial class Person
    {
        public void A()
        {
            Console.WriteLine("this is function A ");
        }
    }

    public partial class Person
    {
        public void B()
        {
            Console.WriteLine("this is function B ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.B();
            person.A();
            Console.ReadLine();

        }
    }

}