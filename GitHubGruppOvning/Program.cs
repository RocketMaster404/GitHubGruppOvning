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
            Console.WriteLine("1. Addera");
            Console.WriteLine("2. Subtrahera");
            Console.WriteLine("3. Multiplicera");
            Console.WriteLine("4. Dividera");
            int input;
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Du måste ange ett heltal");
            }

            switch (input)
            {
                case 1:
                    // Addition
                    // Addition
                    Console.WriteLine("Skriv första talet:");
                    numberOne = int.Parse(Console.ReadLine());

                    Console.WriteLine("Skriv andra talet:");
                    numberTwo = int.Parse(Console.ReadLine());

                    sum = numberOne + numberTwo;
                    Console.WriteLine("Summan är: " + sum);
                    break;

                case 2:
                    Console.WriteLine("Välj ditt första tal:");
                    numberOne = int.Parse(Console.ReadLine());
                    Console.WriteLine("Välj ditt andra tal.");
                    numberTwo = int.Parse(Console.ReadLine());
                    sum = numberOne - numberTwo;
                    Console.WriteLine($"{numberOne} - {numberTwo} = {sum} ");
                    break;
                case 3:
                    Console.WriteLine("Ange tal 1: ");
                    while (!int.TryParse(Console.ReadLine(), out numberOne))
                    {
                        Console.WriteLine(" Du måste ange heltal");
                    }

                    Console.WriteLine("Ange tal 2: ");
                    while (!int.TryParse(Console.ReadLine(), out numberTwo))
                    {
                        Console.WriteLine(" Du måste ange heltal");
                    }

                    sum = numberOne * numberTwo;

                    Console.WriteLine($"{numberOne} * {numberTwo} = {sum}");
                    //Multiplikation
                    break;
                case 4:
                    Console.WriteLine("Ange ditt första tal.");
                    numberOne = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ange ditt andra tal.");
                    numberTwo = int.Parse(Console.ReadLine());
                    sum = numberOne / numberTwo;
                    Console.WriteLine($"{numberOne} / {numberTwo} = {sum}");


                    break;
            }
        }
    }
}
