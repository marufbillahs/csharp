using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implicitandexplicit
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // impicit conversion
            int num = 12390532;
            long bigNum = num;
            Console.WriteLine(bigNum);

            float myFloat = 13.37F;
            double myNewDouble = myFloat;
            Console.WriteLine(myNewDouble);

            // explicit conversion
            // cast double to int;
            double myDouble = 13.37;
            int myInt = (int)myDouble;
            Console.WriteLine(myInt);



            //type casting=convert one data type to another data type
            double a = 3.14;
            int b = Convert.ToInt32(a);
            Console.WriteLine(b);
            Console.WriteLine(a.GetType());

            int c = 123;
            double d = Convert.ToDouble(c) + 0.1;
            Console.WriteLine(d);
            Console.WriteLine(c.GetType());

            int e = 123;
            string f = Convert.ToString(e);
            Console.WriteLine(f);
            Console.WriteLine(f.GetType());

            string g = "$";
            char h = Convert.ToChar(g);
            Console.WriteLine(h);
            Console.WriteLine(h.GetType());


            // typeConversion 
            string myString = Convert.ToString(myDouble); // "13.37"
            Console.WriteLine(myString);

            string myFloatString = myFloat.ToString();
            Console.WriteLine(myFloatString);

            bool sunIsShining = false;
            string myBoolString = sunIsShining.ToString();
            Console.WriteLine(sunIsShining);

            float myNewFloat = float.Parse(Console.ReadLine());//when i convert string input to integer/double/float then used parse otherwise not use parse
            Console.WriteLine(myNewFloat);
        }
    }
}
