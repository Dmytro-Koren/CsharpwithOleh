using System;

namespace Task_1_helloworld_currentdate_
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello World!";
            DateTime currentData =  DateTime.Now;
            Console.WriteLine(text + " " + currentData);
            Console.ReadKey();
        }
    }
}
