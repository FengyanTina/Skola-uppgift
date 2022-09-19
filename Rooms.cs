class Rooms
{

 public static void RoomsMenu()
    {
       Console.Clear ();
      Console.Write ("*********************************************\n");
      Console.WriteLine("Now you are in Rooms!");
      Console.WriteLine("On the menu below are things you can see here .");
      
      Console.WriteLine("1. Exhibitionroom 1");
      Console.WriteLine("2. Exhibitionroom 2");
      Console.WriteLine("3. Café");
      Console.WriteLine("4. Giftshop");
      Console.WriteLine("5. Back to main menu");
      Console.WriteLine("6. Exit the Museum");

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
            Console.Clear ();
            Console.Write ("       Saltwater Evaporating: \n");
            Console.Write ("*********************************************\n");   //Saltwater evaporating
             Console.Write ("* In Japan there is no natural salt depoits *\n");
            Console.Write ("* so they enginered a way to make eatable   *\n");
            Console.Write ("* salt by saltwater evaporation.            *\n");
            Console.Write ("* Visit our exhibition to experience the    *\n");
            Console.Write ("* enginuity and history of evaporating      *\n");
            Console.Write ("* saltwater.                                *\n");
            Console.Write ("*********************************************\n");
            Console.WriteLine("Select an option to continue.");
            Console.Write ("1. Back to Rooms menu\n");      
            Console.Write ("2. Exit Museum\n");
            
            string x= Console.ReadLine ();
            if (x=="1")
            {

              RoomsMenu(); // we can also use "return"
            }

            else if (x=="2")
            {
              Console.Write ("Have a graet day! Please visit again...");
              Environment.Exit (0);
            }
          
            break;

        case 2:
             Console.Clear ();
            Console.Write(".....you can see collection of Pipes and Pictures of Himalaya ");
            Console.Write ("Select an option to continue.\n");          
            Console.Write ("1. Back to Rooms menu\n");
            Console.Write ("2. Exit Museum\n");
            Console.Write ("3. Pipes\n");
            Console.Write ("4. Pictures of Himalaya\n");
            string y= Console.ReadLine ();
            if (y=="1")
            {

              RoomsMenu();//we can use "return;"
            }

            else if (y=="2")
            {
              Console.Write ("Have a graet day! Please visit again...");
              Environment.Exit (0);
            }
            else if(y=="3")
            {

              Console.Write ("               Pipes:\n");
              Console.Write ("*********************************************\n");             //pipes
              Console.Write ("* The exhibition of pipes containes the     *\n");
              Console.Write ("* old-fashioned kizami (kiseru tobacco) and *\n");
              Console.Write ("* the kiseru (Japanese pipe), amongst many  *\n");
              Console.Write ("* other attractions.                        *\n");
              Console.Write ("* Follow the tobacco history from the old   *\n");
              Console.Write ("* days private sector to gouvernment        *\n");
              Console.Write ("* enterprice.                               *\n");
              Console.Write ("*********************************************\n");
            }

            else if (y=="4")
            {

              Console.Write ("          Pictures of Himalaya\n");
              Console.Write ("*********************************************\n");          
              Console.Write ("* See the amazing echibition of pictures    *\n");
              Console.Write ("* featuring the Himalaya, wich has a big    *\n");
              Console.Write ("* export of salt. Follow the Pictures and   *\n");
              Console.Write ("* and learn the history of salt.            *\n");
              Console.Write ("*********************************************\n");//link
            }  

            break;
            
        case 3:
              Console.Clear ();
             Console.Write ("       Café Menu  \n");
              Console.Write ("*******************************************\n");       
              Console.Write ("*  Coffee 340(JPY)   Sandwich   520(JPY)  *\n");
              Console.Write ("*  Tea    200(JPY)   Buns       400(JPY)  *\n");
              Console.Write ("*  Soda   124(JPY)   Cookies    200(JPY)  *\n");
              Console.Write ("*  Water  91(JPY)    ice cream  205(JPY)  *\n");
              Console.Write ("*                                         *\n");
              Console.Write ("*         Enjoy yourself!                 *\n");
              Console.Write ("*******************************************\n");
            Console.Write ("Select an option to continue\n");          
            Console.Write ("1. Back to Rooms menu\n");
            Console.Write ("2. Exit Museum\n");
    
            string z= Console.ReadLine ();
            if (z=="1")
            {

              RoomsMenu();
            }

            else if (z=="2")
            {
              Console.Write ("Have a graet day! Please visit again...");
              Environment.Exit (0);
            }
                       
            break;

        case 4:
               Console.Clear ();
              Console.Write ("     Goods for sale \n");
              Console.Write ("*****************************\n");      
              Console.Write ("*   Exhibition Cataloges    *\n");
              Console.Write ("*   World Salt              *\n");
              Console.Write ("*   Reference Books         *\n");
              Console.Write ("*   Kitchen Utensils        *\n");
              Console.Write ("*   Smoking Items           *\n");
              Console.Write ("*****************************\n");
            Console.Write ("Select an option to continue\n");          
            Console.Write ("1. Back to Rooms menu\n");
            Console.Write ("2. Exit Museum\n");
            string j= Console.ReadLine ();
            if (j=="1")
            {

              RoomsMenu();
            }

            else if (j=="2")
            {
              Console.Write ("Have a graet day! Please visit again...");
              Environment.Exit (0);
            }
                        
           
            break;

        case 5:

           return;
      
        case 6:
            
            Console.Write ("Have a graet day! Please visit again...");
            Environment.Exit(0);
            break;

        default:
            break;
    }
    }
}