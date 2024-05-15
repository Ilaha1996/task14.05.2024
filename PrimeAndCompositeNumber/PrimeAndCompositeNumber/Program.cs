namespace PrimeAndCompositeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 11;
            int counter = 0;


            for (int i = 2; i < num; i++)

            {

                if (num % i == 0)
                {

                    Console.WriteLine(num + " is a composite number");
                    counter++;
                    break;
                }

            }

            if (counter == 0)

            {
                Console.WriteLine(num + " is a prime number");

            }
        }
    }
}
