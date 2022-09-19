class Entrance
{
  public   static void EntranceMenu()
    {
      Console.Clear ();
     Console.Write ("\n*********************************************\n"); 
    Console.WriteLine("Now you are in Entrance!");
    Console.WriteLine("On the menu below are things you can see here .");

    Console.WriteLine("1. Salt sculpture");
    Console.WriteLine("2. Cigars");
    Console.WriteLine("3. Main menu");
    Console.WriteLine("4. Exit Museum");

    int choice;
    bool success;
    do
    {
        Console.Write("Select an option to continue: \n");
        success = int.TryParse(Console.ReadLine(), out choice);
       
    }
     while (!success);

    switch (choice)
    {
        case 1:
             Console.Clear ();
             Console.Write ("           Salt sculptures \n");
              Console.Write ("*********************************************\n");   
              Console.Write ("* Walk through the collection of amazing    *\n");
              Console.Write ("* sculptures made of salt.                  *\n");
              Console.Write ("* The realistic and the abstract art will   *\n");
              Console.Write ("* provide you with an uniqe experience on   *\n");
              Console.Write ("* what at can be made out of salt.             *\n");//link
              Console.Write ("*********************************************\n");

            Console.Write ("Choose an option to continue:");          
            Console.Write ("\n1. Back to Entrance menu\n");
            Console.Write ("2. Exit Museum\n");

            Console.Write ("Select an option to continue: ");
            string a= Console.ReadLine ();
            if (a=="1")
            {

              EntranceMenu ();//we can also use "return"
            }

            else if (a=="2")
            {
              Console.Write ("Have a graet day! Please visit again...");
              Environment.Exit (0);
            }
                  
            break;

        case 2:
             Console.Clear ();
             Console.Write ("               Cigars \n");
              Console.Write ("***********************************************\n");   
              Console.Write ("* Visit our cigar section and find out where  *\n");
              Console.Write ("* they come from and how they are made.       *\n");
              Console.Write ("* Learn the uses and differences through out  *\n");
              Console.Write ("* the history and experience the major        *\n");
              Console.Write ("* collection of the exhibition.               *\n");
              Console.Write ("***********************************************\n");
            Console.Write ("Select an option to continue\n");          
            Console.Write ("1. Back to Entrance menu\n");
            Console.Write ("2. Exit Museum\n");
           
            string b= Console.ReadLine ();
            if (b=="1")
            {

              EntranceMenu();
            }

            else if (b=="2")
            {
              Console.Write ("Have a graet day! Please visit again...");
              Environment.Exit (0);
            }
            
            break;

        case 3:
            return;

        case 4:
            Console.Write("Have a graet day! Please visit again...");
            Environment.Exit(0);
            break;

        default:
            break;
    }
    }
    }
