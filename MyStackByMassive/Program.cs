using System.Drawing;

namespace MyStackByMassive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStackByMassive myStackByMassive = new MyStackByMassive();
            myStackByMassive.Push(5);
            myStackByMassive.Push(6);
            myStackByMassive.Push(7);
            Console.WriteLine(myStackByMassive.Peek());
        }
    }
}
