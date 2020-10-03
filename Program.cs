using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Try again");
            Box myBox = new Box();
            myBox.setHigth(5);
            myBox.setLength(5);
            myBox.setWidth(5);
            Console.WriteLine("Volume is {0} {1}", myBox.getVolume(), "m3");

        }
    }
}
