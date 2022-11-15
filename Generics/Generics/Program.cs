using System; 
 
namespace Generics
{
    internal class Program
    {


        class Example
        {
            public static void showarry <T> (T[] number)
            {
                for(int i =0;i<number.Length; i++)
                {
                    Console.WriteLine(number[i]);
                }
            }

            //public static void showarry(string[] number)
            //{
            //    for (int i = 0; i < number.Length; i++)
            //    {
            //        Console.WriteLine(number[i]);
            //    }
            //}
            //int[] arr = new int[4];

        }
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            arr[0] = 11;
            arr[1] = 22;
            arr[2] = 33;
            arr[3] = 44;
            arr[4] = 55;

            string[] names = new string[3];
            names[0] = "aditya";
            names[1] = "digya";
            names[2] = "digi";

            double[] arr1 = { 2.5, 3.5, 4.5, 6.5 };
            Example.showarry(arr1);


            Example.showarry(arr);
            Example.showarry(names);
            Console.ReadLine();
            Console.WriteLine("Hello World!");
        }
    }
}
