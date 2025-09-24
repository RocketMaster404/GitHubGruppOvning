namespace GitHubGruppOvning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne;
            int numberTwo;
            int sum;

            Console.WriteLine("Ange ditt val");
            int input;
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Du måste ange ett heltal");
            }

            switch (input)
            {
                case 1:
                    {        // Addition
                        Console.WriteLine("Skriv första talet:");
                        numberOne = int.Parse(Console.ReadLine());

                        Console.WriteLine("Skriv andra talet:");
                        numberTwo = int.Parse(Console.ReadLine());

                        sum = numberOne + numberTwo;
                        Console.WriteLine("Summan är: " + sum);
                        break;
                    }
                case 2:
                    // Subtraktion
                    break;
                case 3:
                    //Multiplikation
                    break;
                case 4:
                    // Division
                    break;

            }


        }
    }
}
