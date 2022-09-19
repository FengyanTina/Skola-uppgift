internal class Program
{
    private static void Main(string[] args)
    {

    while (true)
    {
     Console.Clear ();
    Console.Write ("*******************************************\n");
    Console.Write ("Welcom to Tobacco and Salt Museum!\nNow your addventure has started.\n");
    Console.Write ("There are two main sections to visit: Entrance and Rooms\n");

    Console.Write("\nIn Entrance you can visit:\n*Salt sculptures\n*Cigars\n");
    Console.Write("\nIn Rooms you can visit:\n*Exhibitionroom1\n*Exhibitionroom2\n*Café\n*Giftshop\n");

    Console.Write ("\n*******************************************");
    Console.WriteLine("\nSelect where you want to go.");
    Console.WriteLine("1. Entrance");
    Console.WriteLine("2. Rooms");
    Console.WriteLine("3. Exit");


    Console.Write("Select an option to continue: ");

    int choice;
    bool success;

    do
    {
        success = int.TryParse(Console.ReadLine(), out choice);
    }
    while (!success);
         

    switch (choice)
    {
        case 1:
            
            Entrance.EntranceMenu();
            break;

        case 2:
            
            Rooms.RoomsMenu ();
            break;

        case 3:
            Console.Write ("Have a graet day! Please visit again...");
            Environment.Exit(0);
            break;
        
        default:
            break;
    }
    }
    }

    }