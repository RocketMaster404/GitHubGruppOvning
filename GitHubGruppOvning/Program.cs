namespace GitHubGruppOvning
{
    internal class Program
    {
        static void Main(string[] args)
        {
         int numberOne;
         int numberTwo;

         Console.WriteLine("Ange ditt val");
         int input;
         while(!int.TryParse(Console.ReadLine(), out input))
         {
            Console.WriteLine("Du måste ange ett heltal");
         }

         switch (input)
         {
            case 1:
               // Addition
               break;
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
