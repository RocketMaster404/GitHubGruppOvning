namespace GitHubGruppOvning
{
    internal class Program
    {

      static void Square()
      {
         double length;
         double width;
         double sum;
         Console.WriteLine("Beräkna arean på en fyrkant");
         Console.WriteLine("Ange längd: ");
         while (!double.TryParse(Console.ReadLine(), out length))
         {
            Console.WriteLine("Du måste ange heltal");
         }
         Console.WriteLine("Ange höjd: ");
         while (!double.TryParse(Console.ReadLine(), out width))
         {
            Console.WriteLine("Du måste ange heltal");
         }

         sum = length * width;

         Console.WriteLine($"Arean = {sum}");



      }

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
            Console.WriteLine("5. Potens");
            Console.WriteLine("6. Area av Cirkel");
            Console.WriteLine("7. Area av Fyrkant");
            Console.WriteLine("8. Area av Triangel");
            int input;
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Du måste ange ett heltal");
            }
            switch (input)
            {
                case 1:
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
                    break;
                case 4:
                    Console.WriteLine("Ange ditt första tal.");
                    numberOne = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ange ditt andra tal.");
                    numberTwo = int.Parse(Console.ReadLine());
                    sum = numberOne / numberTwo;
                    Console.WriteLine($"{numberOne} / {numberTwo} = {sum}");
                    break;
                case 5:
                    // KOD
                    break;
                case 6:
                    Console.WriteLine("Ange cirkelns radie: ");
                    double radie = Convert.ToDouble(Console.ReadLine());
                    double area = Math.PI * Math.Pow(radie, 2);
                    Console.WriteLine($"Arean av cirkeln är: {area}.");
                    break;
                case 7:
               Square();
              
                    break;
                case 8:
                    //KOD
                    break;
            }
        }
    }
}
