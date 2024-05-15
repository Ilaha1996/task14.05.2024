using System.ComponentModel.DataAnnotations;

namespace PB201taskİlaha
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int num = int.Parse(Console.ReadLine()); 

            int length = num.ToString().Length; 

            Console.WriteLine("Number of floors: " + length);
        }
    }
}