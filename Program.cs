namespace Lecture_1_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create new instance of Bicycle class
            Bicycle bicycle = new Bicycle(-1);
            Bicycle bicycle2 = new Bicycle(-1);
            Bicycle bicycle3 = bicycle2;
            Console.WriteLine($"bicycle 1 {bicycle}");
            Console.WriteLine($"bicycle 2 {bicycle2}");
            Console.WriteLine($"bicycle 3 {bicycle3}");
        }
    }
}