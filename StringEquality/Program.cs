using System;


namespace StringEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            //string first = "This is a string";
            //string second = "This is a string";
            //Console.WriteLine(first == second);//test that the two objects are the same
            //Console.WriteLine(second == first);//test that the two objects are the same
            //Console.WriteLine(first.Equals(second));//test that object VALUES are the same
            //Console.WriteLine(second.Equals(first));//test that object VALUES are the same

            //------------Section 9 video 131 String Equality---------------------
            string first = "This is a string";
            string second = "THIS IS A STRING";
            Console.WriteLine(first == second);//test that the two objects are the same
            Console.WriteLine(second == first);//test that the two objects are the same
            Console.WriteLine(first.Equals(second, StringComparison.OrdinalIgnoreCase));//test that object VALUES are the same
            Console.WriteLine(second.Equals(first, StringComparison.OrdinalIgnoreCase));//test that object VALUES are the same
        }
    }
}
