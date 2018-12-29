using System;
using System.Threading;
namespace ConsoleApp6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MyString str = new MyString("first ");
            MyString str1 = new MyString("second ");
            MyString str2 = new MyString("third ");
            string str4 = "";
            Console.WriteLine(str4);
            Console.WriteLine(str4);
            Console.WriteLine("Concat " + str.Concat(str1));
            Console.WriteLine("IndexOf " + str.IndexOf('r'));
            Console.WriteLine("Sub " + str.Sub(1, 3));
            Console.WriteLine("Sub " + str1.Sub(3));
            Console.WriteLine("Compare " + MyString.Compare(str1, str));
            Console.WriteLine(str + str1 + str2);
            Console.ReadLine();
        }
    }
}