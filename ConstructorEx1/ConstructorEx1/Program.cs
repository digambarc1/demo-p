
namespace ConstructorEx1
{
    using System;
    internal class Program
    {

        //we are doing the constructor overloading
        public Program()
        {
            Console.WriteLine("default const. invoke");
        }

        public Program(int a,int b,int c)
        {
            Console.WriteLine("Enter the Number");
            Console.WriteLine(a + b + c); ;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Program c = new Program(1, 2, 3);
            Console.ReadLine();

        }
    }
}
