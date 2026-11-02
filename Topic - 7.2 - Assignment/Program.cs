namespace Topic___7._2___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assignment 1
            Console.WriteLine("Press Enter to start the count down.");
            Console.ReadLine();
            for (int i = 10; i >= 0; i -=1)
            {
                Console.WriteLine(i + ". ");
            }
            Console.WriteLine("Blast Off");

            //Assignment 2
            for (int i = -10; i <= 2; i = +10)
            {
                Console.WriteLine(i + ". ");
            }

        }
    }
}
