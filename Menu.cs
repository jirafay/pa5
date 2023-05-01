using System;
using pa5;

namespace pa5
{
    public class Menu
    {

        //create an admin menu method that will display the admin menu with the choices of viewing, editing, or deleting a trainer, viewing, editing, or deleting a listing, or viewing, editing, or deleting a booking
        public static void mainMenu()
        {
            string choice = "";
            Console.Clear();

            string Progressbar =(@" 
                                                                                  #/,/#                                  &  %                                                                           
                                                                             *   #@@@@@#   * (.        .,,.        *(#  (@@@@@/   .                                                                     
                                                                          (  .@@@@,....@@@@ /@@@@@@@@@@%((%@@@@@@@@@@ @@@.....@@@@   ,                                                                  
                                                                           @@@*...........@@&.......................,@@#.........&@@@                                                                   
                                                                     (  @@@&,.............,...........................%.............@@@@  @                                                             
                                                                     .@@@.......@@@@@.......................................*@@@@/....,@@@  ,.                                                          
                                                                %. @@@%......@@@/&@@..........................................@@/&@@.....@@@                                                            
                                                              *  @@@......@@@#(@@@.............................................,@@//@@.....@@@/  .                                                      
                                                              .@@@.....@@@@//@@@.........,.......................................#@#//@@@....%@@(  .                                                    
                                                            #@@@....(@@@////@@......./%@@@@@//.................//(&@&#//,..........@@///@@@....&@@  %.                                                  
                                                           @@(...,@@@#/////@@....../@(@#@@@ @@/,//(,,........//@@&@###&@@@/.........@@////&@@@...@@  *.                                                 
                                                          @@*..#@@&//////(@@......(@ @%@@@@@@@//@,.........../@&@*@@@@@@@ &@........@@//////@@*..*@@  ,.                                                
                                                         @@(...@@////////@@@.......@@.@#&@#@ @@............../@ @#@@@@@#@/@.........,@@//////@@...@@@ *,                                                
                                                        @@@..,@@/////////@@@............#@@@@,..........//,../(@  (@@@@@(............@@///////@&...@@  ,.                                               
                                                     @ &@@...@@//////////@@@...........,/@@*...............//&......................#@@(/////((@...@@@  ,                                               
                                                       @@...%@////////&///@@...........@@@............../(@//(@%...................(@@@///@////@....@@  ,.                                              
                                                    @ &@@...@//////////@@@@@@.........@@@................,(@@//@,................./@@@@@@@@/////%...@@# &,                                              
                                                      @@#..(//////////@@@@@@@@........@@..................//@@/@@...............//@@@@@@@@@/////@...@@@  ,.                                             
                                                      @@*../////////(@@@@   @@@/,....@@@..................//@@@@.............///@@@@@@@@@@@&/////...*@@  ,.                                             
                                                    ( @@@..////////#@@@&     .@@@//,.@@#...............@@//@@@@#../......,///#@@@@  #((  @@@/////...*@@  ,.                                             
                                                       @@@.//////@@@@          #@@@@/@@.............,@@@(%@@@@,@@@...(////@@@@@@  (*,.    *@@@//....@@@ %*.                                             
                                                         @@@@@@@@*                @@@@@.............@@@@@@@@@@@@(/@//(@@@@@@@   #*,.        .@@@@&@@@@  ,,                                              
                                                    .    %@@@@@@@@@@            &@@@@@@............@@@@@@@@@@&(/%@@@@@@@@&&&@@@@@           /         *,,                                               
                                                  ,  @@@@&(/(%@@&..@@@      @@@@@&&&&@@...........(@@@@@@#///&@@@@@@&&&&&&&&&&&&@@@@    #      .,,,,,,.                                                 
                                                   @@@,.......(/(....@@@@@@@&&&&&&&&&@@*..........@@@@@@@@@@@@&&&&&&&&&%&&&&&&&&&&&@@@@@@    @                                                          
                                                / @@@@@@%............,@@@%%%%%%%%%%%%@@@.....@....@@@&&&&&&&&&&&&&&%%%%%%%%%%%&&&&%%@@@%%@@@@@   ,                                                      
                                                 (      @@@@*..........@@@%%%%%%%%%%&@@@.....@,...@@@&&&%%%%%%%%%%%%%%%%%%&&&%%%%%%%#@@%%%%%%&@@@                                                       
                                                     ..,#  /@@@.........@@@#%%%&&&&&&@@@.....@%...%@@&&&%%%%%%#    #%%%%%%&@&&&%%%%%%#%%%%%&@@@@@@@@  &                                                 
                                                         @@@&&@@.........@@&&&&&&&@&%@@@.....@&....@@...          %%%%%%%%%@@@&&&&%%%%%%%&&&&&&&&&&@@@  *                                               
                                                        @@&%%%%@@&.......@@@&&@@@@%%%@@@.....@,....@@&&&%%       %%%%%%%%%%%@@@@@&&&%%&&&&@@@@@@@@@@&@@% (.                                             
                                                     & %@@%%%@@@@@@.......@@@@@@%%%%%@@(....@@....%@@&&%    #   %%%%%%%%%%%%%&@@@@@@&&&&@@@#%%###  @@@@@% @.                                            
                                                        @@@%@@  #@@%.......@@@@#%%%%%@@....,@(....@@&&.   %%   .%%%%%%%%%%%%%&&@@@@@@@@@@@@@@@   %%% @@@@  ,.                                           
                                                       @  @@@,%#. @@........@@@%%%%%@@*...,@@....*@@%.  #%#    %%%%%%%%%%%%%#&@@@@@@@@@@,.,//%@@@  %# @@&  ,.                                           
                                                         %  @@@ &@@@@........@@@%%%@@&....@%....,@@(,  #%%%       %%%%%%%%%%%@@@#.......@@...///@@  %@@@& *,.                                           
                                                           . (@@@@.@@@.......,.@@@@@....@@...../@@@..             %%%%%%%%%%%&@@(........,....///@@@@@@  ,,,                                            
                                                            ,  @@@..@@@.....,@@@@,.../@......,/@@@..(%%%%%    %%%#%%%%%%%%%%%&&@@   @@,......////@@@@  **,.                                             
                                                                @@...@@@,..................(/@@@,. %%%%%%%    %%%%%%%%%%%%%%%&&&@@@,@@.....*///@@@@  **,.                                               
                                                                @@@...@@@(//*.........,//(/@@@#...%%%%%%%%    %%%%%%%%%%%%%%%&&&&@@@...../////@@@  (*,.                                                 
                                                                 @@@..@@@@@@@//////////&@@@@..  %%%%%%%%%%    *#%%  #%%%%%%%%&&&&&@@@   @@///@@@ .*,.                                                   
                                                                  @@@@@@&#%%%@@@@@@@@@@(.... %%%%%%%%%%%%%%       /%%%%%%%%%&&&&&&@@@*.%@(//@@@  ,,                                                     
                                                                     @@@&&&%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&@@@&(@@@@@@  ,,.                                                     
                                                                   / @@@&&&&&&%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&@@@@@@@@@@  *,.                                                      
                                                                     @@@&&&&&&&&&&&%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&@@@@@@   **,.                                                       
                                                                     @@@@&&&&&&&&&&&&&&&&&&&%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&&&&&&&@@@@@  *,.                                                          
                                                                   ,  *@@@@@@&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&@@@@@  @,.                                                           
                                                                     @ (@@@*@@@@@@@&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&@@@@@@@@@  *,.                                                            
                                                                     % (@@@.....,&@@@@@@@@&&&&&&&&&&&&&&&&&&&&&&&&&&&&@@@@@@@@@@#//(@@@  ,,                                                             
                                                                     / %@@@............@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@/..///////@@@  ,.                                                             
                                                                       @@@&..................../@@@@@@@@@@@@@@&*.............///////@@@  ,.                                                             
                                                                       @@@....................................................//////@@@  ,.                                                             
                                                                       @@@......................@@@@@@@@@@@@@.................//////@@@  ,.                                                             
                                                                       @@@................../@@@@     *,    ,@@@/............../////@@@  *.                                                             
                                                                      .@@................,(@@@   ,,*,.     .#  @@@#............/////@@@  ,.                                                             
                                                                    / @@@..............,//@@&  *,,            .  @@@............/////@@  *,                                                             
                                                                      @@*.............//(@@  *,,                & /@@,..........*////@@* %,                                                             
                                                                   # &@@............*//#@@  *,.                  % .@@...........////@@@  ,.                                                            
                                                                     @@............(//(@@  *,.                    # &@@...........////@@  ,.                                                            
                                                                  . @@@...........///(@@@ @,.                        @@@..........////@@( @,                                                            
                                                                 @ %@@...........////@@@  ,,                       % ,@@...........///#@@  ,.                                                           
                                                                * /@@............///@@@@ @,.                          @@@...........///@@@ /,                                                           
                                                                 @@@............////@@@  ,,                           @@@............///@@  (.                                                          
                                                             .  @@@............,///%@@@  ,,                           @@@............///(@@  *.                                                         
                                                         .   .@@@..............////@@@@  ,.                           @@@.............///(@@  (                                                         
                                                     %  (@@@@@,................////@@@@  ,.                           @@@..............////@@* ..                                                       
                                                   #  @@@&@//................./////@@@@  ..                          @@@@.............../(//@@@@    #.                                                  
                                                  # %@@  @#///////*,......*//////////@@@@  ,                       @@@@#......................./@@@@(  *                                                
                                                  , @@@@&/&@,  .@/////@@@@///////////&@@@  ,.                     @@@@//(/,,...............,/////@ &@@@  .                                              
                                                     @@@@@*   ..@//(@.   .@@///////%@@@@  ,,.                     @@@%//////////#(////////@@@&///@  /@@  ,.                                             
                                                        @@@@@@@@@//@/    ..@#(@@@@@@@   ,*,.                       @@@@(////(@&   .@(///(@   .@@//@@@@@  *,                                             
                                                       .(    (@@@@@@@@@@@@@@@@@(    (*,,.                         ,  @@@@@@#@@    ..@/(/@@   ..&@@@@@  #*,.                                             
                                                           .,,&,             @*,*,,,.                               .    @@@@@@@@@@@@@@@@@@@@@@@@/   *,,.                                               
                                                                   .........                                           ..#      /%@@@@@@&(.     (*,,,.                                                  
                                                                                                                             ..,,,,,*****,,,*,,..                                                       
                                                                                                                                                                                          ");
            
            var title = "";
            for (int i = 0; i < Progressbar.Length; i++)
            {
                title += Progressbar[i];
                Console.WriteLine(title);
                Thread.Sleep(1);
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.ResetColor();
            title = "";  
            System.Console.WriteLine(@"                                                                                ██╗   ██╗ █████╗      ██████╗██╗   ██╗███╗   ███╗
                                                                                ██║   ██║██╔══██╗    ██╔════╝╚██╗ ██╔╝████╗ ████║
                                                                                ██║   ██║███████║    ██║  ███╗╚████╔╝ ██╔████╔██║
                                                                                ██║   ██║██╔══██║    ██║   ██║ ╚██╔╝  ██║╚██╔╝██║
                                                                                ╚██████╔╝██║  ██║    ╚██████╔╝  ██║   ██║ ╚═╝ ██║
                                                                                ╚═════╝ ╚═╝  ╚═╝     ╚═════╝   ╚═╝   ╚═╝     ╚═╝
                                                 
");
                    
            System.Console.WriteLine("Welcome to the UA Gym Online Booking System!");
            System.Console.WriteLine("Please choose which category best describes you:");
            System.Console.WriteLine("1. Admin or Trainer");
            System.Console.WriteLine("2. Customer");
            System.Console.WriteLine("");
            System.Console.WriteLine("3. Exit");
            choice = Console.ReadLine();


            //create  a try-catch block to catch any exceptions and only allow the user to enter a valid choice of Admin, Trainer, or Customer and keep prompting them until they do for the rest of the program

            while (choice != "3")
            {
                if (choice == "1")
                {
                    System.Console.WriteLine("Please enter your password:");
                    string password = Console.ReadLine();
                    //parse through the adminpassword.txt and check if it is found
                    //if it is found, then go to the admin menu
                    //if it is not, parse through the trainerpassword.txt and check if it is found
                    //if it is found, then go to the trainer menu
                    //if it is not, then keep prompting the user to enter the correct password
                    
                    string[] adminpassword = File.ReadAllLines("adminpasswords.txt");
                    string[] trainerpassword = File.ReadAllLines("trainerpasswords.txt");
                    //check if the password is found in the adminpassword.txt in any of the lines
                    if (adminpassword.Contains(password))
                    {
                        adminMenu();
                    }

                    //check if the password is found in the trainerpassword.txt in any of the lines
                    else if (trainerpassword.Contains(password))
                    {
                        trainerMenu();
                    }
                    else
                    {
                        System.Console.WriteLine("Invalid password. Please try again.");
                        password = Console.ReadLine();
                    }

                }
                else if (choice == "2")
                {
                    customerMenu();
                }
                else if (choice == "3")
                {
                    customerMenu();
                }
                else if(choice !="1" || choice !="2" || choice !="2"){
                    System.Console.WriteLine("Invalid choice. Please try again.");
                    choice=Console.ReadLine();
                }
            }
            Environment.Exit(0);
        }


        public static void adminMenu()
        {
            //change the colors of the console
            //keep changing the color from blue to red
            //for loop repeats 10 times



            System.Console.WriteLine(@"___       __    ______                                 ________________          _____        
__ |     / /_______  /__________________ ________      ___    |_____  /______ ______(_)______ 
__ | /| / /_  _ \_  /_  ___/  __ \_  __ `__ \  _ \     __  /| |  __  /__  __ `__ \_  /__  __ \
__ |/ |/ / /  __/  / / /__ / /_/ /  / / / / /  __/     _  ___ / /_/ / _  / / / / /  / _  / / /
____/|__/  \___//_/  \___/ \____//_/ /_/ /_/\___/      /_/  |_\__,_/  /_/ /_/ /_//_/  /_/ /_/ 
                                                                                              
");

            string choice = "";
            System.Console.WriteLine("Please choose from the following options:");
            System.Console.WriteLine("1. Trainer");
            System.Console.WriteLine("2. Listing");
            System.Console.WriteLine("3. Booking");
            System.Console.WriteLine("4. Reports");
            System.Console.WriteLine("");
            System.Console.WriteLine("5. Exit");
            choice = Console.ReadLine().ToLower();
            while (choice != "5")
            {
                if (choice == "1")
                {
                    System.Console.WriteLine("Please choose from the following options:");
                    System.Console.WriteLine("1. View");
                    System.Console.WriteLine("2. Edit");
                    System.Console.WriteLine("3. Delete");
                    System.Console.WriteLine("4. See Trainer Feedback and Ratings");
                    choice = Console.ReadLine().ToLower();
                    if (choice == "1")
                    {
                        TrainerUtility.DisplayTrainers();
                        //ask if they want to exit
                        System.Console.WriteLine("Would you like to exit? (y/n)");
                        string exitChoice = Console.ReadLine().ToLower();
                        if (exitChoice == "y")
                        {
                            Environment.Exit(0);
                        }
                        System.Console.WriteLine("Please choose from the following options:");
                        System.Console.WriteLine("1. Trainer");
                        System.Console.WriteLine("2. Listing");
                        System.Console.WriteLine("3. Booking");
                        System.Console.WriteLine("4. Reports");
                        choice=Console.ReadLine().ToLower();
                    }
                    else if (choice == "2")
                    {
                        TrainerUtility.EditTrainer();
                        //ask if they want to exit
                        System.Console.WriteLine("Would you like to exit? (y/n)");
                        string exitChoice = Console.ReadLine().ToLower();
                        if (exitChoice == "y")
                        {
                            Environment.Exit(0);
                        }
                        System.Console.WriteLine("Please choose from the following options:");
                        System.Console.WriteLine("1. Trainer");
                        System.Console.WriteLine("2. Listing");
                        System.Console.WriteLine("3. Booking");
                        System.Console.WriteLine("4. Reports");
                        choice=Console.ReadLine().ToLower();
                    }
                    else if (choice == "3")
                    {
                        TrainerUtility.DeleteTrainer();
                        System.Console.WriteLine("Would you like to exit? (y/n)");
                        string exitChoice = Console.ReadLine().ToLower();
                        if (exitChoice == "y")
                        {
                            Environment.Exit(0);
                        }
                        System.Console.WriteLine("Please choose from the following options:");
                        System.Console.WriteLine("1. Trainer");
                        System.Console.WriteLine("2. Listing");
                        System.Console.WriteLine("3. Booking");
                        System.Console.WriteLine("4. Reports");
                        choice=Console.ReadLine().ToLower();
                    }
                    else if (choice == "4"){
                        Feedback.ViewFeedback();
                        System.Console.WriteLine("Would you like to exit? (y/n)");
                        string exitChoice = Console.ReadLine().ToLower();
                        if (exitChoice == "y")
                        {
                            Environment.Exit(0);
                        }
                        System.Console.WriteLine("Please choose from the following options:");
                        System.Console.WriteLine("1. Trainer");
                        System.Console.WriteLine("2. Listing");
                        System.Console.WriteLine("3. Booking");
                        System.Console.WriteLine("4. Reports");
                        choice=Console.ReadLine().ToLower();
                    }
                }
                else if (choice == "2")
                {
                    System.Console.WriteLine("Please choose from the following options:");
                    System.Console.WriteLine("1. View");
                    System.Console.WriteLine("2. Edit");
                    System.Console.WriteLine("3. Delete");
                    choice = Console.ReadLine().ToLower();
                    if (choice == "1")
                    {
                        ListingUtility.DisplayListings();
                        System.Console.WriteLine("Would you like to exit? (y/n)");
                        string exitChoice = Console.ReadLine().ToLower();
                        if (exitChoice == "y")
                        {
                            Environment.Exit(0);
                        }
                        System.Console.WriteLine("Please choose from the following options:");
                        System.Console.WriteLine("1. Trainer");
                        System.Console.WriteLine("2. Listing");
                        System.Console.WriteLine("3. Booking");
                        System.Console.WriteLine("4. Reports");
                        choice=Console.ReadLine().ToLower();
                    }
                    else if (choice == "2")
                    {
                        ListingUtility.EditListing();
                        System.Console.WriteLine("Would you like to exit? (y/n)");
                        string exitChoice = Console.ReadLine().ToLower();
                        if (exitChoice == "y")
                        {
                            Environment.Exit(0);
                        }
                        System.Console.WriteLine("Please choose from the following options:");
                        System.Console.WriteLine("1. Trainer");
                        System.Console.WriteLine("2. Listing");
                        System.Console.WriteLine("3. Booking");
                        System.Console.WriteLine("4. Reports");
                        choice=Console.ReadLine().ToLower();
                    }
                    else if (choice == "3")
                    {
                        ListingUtility.DeleteListing();
                        System.Console.WriteLine("Would you like to exit? (y/n)");
                        string exitChoice = Console.ReadLine().ToLower();
                        if (exitChoice == "y")
                        {
                            Environment.Exit(0);
                        }
                        System.Console.WriteLine("Please choose from the following options:");
                        System.Console.WriteLine("1. Trainer");
                        System.Console.WriteLine("2. Listing");
                        System.Console.WriteLine("3. Booking");
                        System.Console.WriteLine("4. Reports");
                        choice=Console.ReadLine().ToLower();
                    }
                }
                else if (choice == "3")
                {
                    System.Console.WriteLine("Please choose from the following options:");
                    System.Console.WriteLine("1. View");
                    System.Console.WriteLine("2. Book");
                    System.Console.WriteLine("3. Update");
                    choice = Console.ReadLine().ToLower();
                    if (choice == "1")
                    {
                        BookingsUtility.DisplayBookings();
                        System.Console.WriteLine("Would you like to exit? (y/n)");
                        string exitChoice = Console.ReadLine().ToLower();
                        if (exitChoice == "y")
                        {
                            Environment.Exit(0);
                        }
                        System.Console.WriteLine("Please choose from the following options:");
                        System.Console.WriteLine("1. Trainer");
                        System.Console.WriteLine("2. Listing");
                        System.Console.WriteLine("3. Booking");
                        System.Console.WriteLine("4. Reports");
                        choice=Console.ReadLine().ToLower();
                    }
                    else if (choice =="2"){
                        BookingsUtility.BookSession();
                        System.Console.WriteLine("Would you like to exit? (y/n)");
                        string exitChoice = Console.ReadLine().ToLower();
                        if (exitChoice == "y")
                        {
                            Environment.Exit(0);
                        }
                        System.Console.WriteLine("Please choose from the following options:");
                        System.Console.WriteLine("1. Trainer");
                        System.Console.WriteLine("2. Listing");
                        System.Console.WriteLine("3. Booking");
                        System.Console.WriteLine("4. Reports");
                        choice=Console.ReadLine().ToLower();
                    }
                    else if (choice == "3")
                    {
                        BookingsUtility.UpdateSession();
                        System.Console.WriteLine("Would you like to exit? (y/n)");
                        string exitChoice = Console.ReadLine().ToLower();
                        if (exitChoice == "y")
                        {
                            Environment.Exit(0);
                        }
                        System.Console.WriteLine("Please choose from the following options:");
                        System.Console.WriteLine("1. Trainer");
                        System.Console.WriteLine("2. Listing");
                        System.Console.WriteLine("3. Booking");
                        System.Console.WriteLine("4. Reports");
                        choice=Console.ReadLine().ToLower();
                    }
                }
                else if (choice == "4")
                {
                    System.Console.WriteLine("Please choose from the following options:");
                    System.Console.WriteLine("1. Individual Trainer Report");
                    System.Console.WriteLine("2. Historical Customer Report");
                    System.Console.WriteLine("3. Historical Revenue Report");
                    choice = Console.ReadLine();
                    if (choice == "1")
                    {
                        Reports.IndividualCustomer();
                        System.Console.WriteLine("Would you like to exit? (y/n)");
                        string exitChoice = Console.ReadLine().ToLower();
                        if (exitChoice == "y")
                        {
                            Environment.Exit(0);
                        }
                        System.Console.WriteLine("Please choose from the following options:");
                        System.Console.WriteLine("1. Trainer");
                        System.Console.WriteLine("2. Listing");
                        System.Console.WriteLine("3. Booking");
                        System.Console.WriteLine("4. Reports");
                        choice=Console.ReadLine().ToLower();
                    }
                    else if (choice == "2")
                    {
                        Reports.HistoricalCustomer();
                        System.Console.WriteLine("Would you like to exit? (y/n)");
                        string exitChoice = Console.ReadLine().ToLower();
                        if (exitChoice == "y")
                        {
                            Environment.Exit(0);
                        }
                        System.Console.WriteLine("Please choose from the following options:");
                        System.Console.WriteLine("1. Trainer");
                        System.Console.WriteLine("2. Listing");
                        System.Console.WriteLine("3. Booking");
                        System.Console.WriteLine("4. Reports");
                        choice=Console.ReadLine().ToLower();
                    }
                    else if (choice == "3")
                    {
                        Reports.HistoricalRevenue();
                        System.Console.WriteLine("Would you like to exit? (y/n)");
                        string exitChoice = Console.ReadLine().ToLower();
                        if (exitChoice == "y")
                        {
                            Environment.Exit(0);
                        }
                        System.Console.WriteLine("Please choose from the following options:");
                        System.Console.WriteLine("1. Trainer");
                        System.Console.WriteLine("2. Listing");
                        System.Console.WriteLine("3. Booking");
                        System.Console.WriteLine("4. Reports");
                        choice=Console.ReadLine().ToLower();
                    }
                }
                else if (choice == "5")
                {
                    Environment.Exit(0);
                }
            }
        }



        public static void trainerMenu()
        {
            //the first choices should be: View, Edit, Delete
            //then the user should be able to choose to view, edit, or delete a trainer
            //format it like we did for customermenu in terms of while exit is false and error handling
            System.Console.WriteLine(@"___       __    ______                                 ________             _____                    
__ |     / /_______  /__________________ ________      ___  __/____________ ___(_)___________________
__ | /| / /_  _ \_  /_  ___/  __ \_  __ `__ \  _ \     __  /  __  ___/  __ `/_  /__  __ \  _ \_  ___/
__ |/ |/ / /  __/  / / /__ / /_/ /  / / / / /  __/     _  /   _  /   / /_/ /_  / _  / / /  __/  /    
____/|__/  \___//_/  \___/ \____//_/ /_/ /_/\___/      /_/    /_/    \__,_/ /_/  /_/ /_/\___//_/     
                                                                                                     ");
            string choice = "";

            System.Console.WriteLine("Please choose from the following options:");
            System.Console.WriteLine("1. View");
            System.Console.WriteLine("2. Edit");
            System.Console.WriteLine("3. Delete");
            System.Console.WriteLine("");
            System.Console.WriteLine("4. Exit");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                TrainerUtility.DisplayTrainers();
                //ask if they want to exit

                System.Console.WriteLine("Would you like to exit? (y/n)");
                string exitChoice = Console.ReadLine().ToLower();
                if (exitChoice == "y")
                {
                    Environment.Exit(0);
                }
                System.Console.WriteLine("Please choose from the following options:");
                System.Console.WriteLine("1. View");
                System.Console.WriteLine("2. Edit");
                System.Console.WriteLine("3. Delete");
                System.Console.WriteLine("");
                System.Console.WriteLine("4. Exit");

            }
            else if (choice == "2")
            {
                TrainerUtility.EditTrainer();

                //ask if they want to exit

                System.Console.WriteLine("Would you like to exit? (y/n)");
                string exitChoice = Console.ReadLine().ToLower();
                if (exitChoice == "y")
                {
                    Environment.Exit(0);
                }
                System.Console.WriteLine("Please choose from the following options:");
                System.Console.WriteLine("1. View");
                System.Console.WriteLine("2. Edit");
                System.Console.WriteLine("3. Delete");
                System.Console.WriteLine("");
                System.Console.WriteLine("4. Exit");
            }
            else if (choice == "3")
            {
                TrainerUtility.DeleteTrainer();

                //ask if they want to exit

                System.Console.WriteLine("Would you like to exit? (y/n)");
                string exitChoice = Console.ReadLine().ToLower();
                if (exitChoice == "y")
                {
                    Environment.Exit(0);
                }
                System.Console.WriteLine("Please choose from the following options:");
                System.Console.WriteLine("1. View");
                System.Console.WriteLine("2. Edit");
                System.Console.WriteLine("3. Delete");
                System.Console.WriteLine("");
                System.Console.WriteLine("4. Exit");
            }
            else if (choice == "4")
            {
                Environment.Exit(0);
            }
        }



        public static void customerMenu()
        {
            System.Console.WriteLine(@"___       __    ______                                 _________             _____                              
__ |     / /_______  /__________________ ________      __  ____/___  __________  /_____________ ________________
__ | /| / /_  _ \_  /_  ___/  __ \_  __ `__ \  _ \     _  /    _  / / /_  ___/  __/  __ \_  __ `__ \  _ \_  ___/
__ |/ |/ / /  __/  / / /__ / /_/ /  / / / / /  __/     / /___  / /_/ /_(__  )/ /_ / /_/ /  / / / / /  __/  /    
____/|__/  \___//_/  \___/ \____//_/ /_/ /_/\___/      \____/  \__,_/ /____/ \__/ \____//_/ /_/ /_/\___//_/     
                                                                                                                ");
            string choice = "";
            System.Console.WriteLine("Please choose from the following options:");
            System.Console.WriteLine("1. Trainers");
            System.Console.WriteLine("2. Bookings");
            System.Console.WriteLine("3. Workout Generator (Please not this is using an API so it takes a while to load so please go to Program.cs and run where it is commeneted to see feature");
            System.Console.WriteLine("4. Feeback and Ratings");
            System.Console.WriteLine("4. Exit");
            while (choice != "5")
            {
                if (choice == "1")
                {
                    TrainerUtility.DisplayTrainers();

                    //ask if they want to exit
                    System.Console.WriteLine("Would you like to exit? (y/n)");
                    string exitChoice = Console.ReadLine().ToLower();
                    if (exitChoice == "y")
                    {
                        System.Console.WriteLine("Thank you for using our service. Have a nice day!");
                        Environment.Exit(0);
                    }
                        System.Console.WriteLine("Please choose from the following options:");
                        System.Console.WriteLine("1. Trainers");
                        System.Console.WriteLine("2. Bookings");
                        System.Console.WriteLine("3. Workout Generator (Please not this is using an API so it takes a while to load so please go to Program.cs and run where it is commeneted to see feature");
                        System.Console.WriteLine("4. Exit");

                }
                else if (choice == "2")
                {
                    BookingsUtility.DisplayBookings();
                    System.Console.WriteLine("These are the available sessions. Please choose one to book.");
                    BookingsUtility.BookSession();
                    //ask if they want to exit
                    System.Console.WriteLine("Would you like to exit? (y/n)");
                    string exitChoice = Console.ReadLine().ToLower();
                    if (exitChoice == "y")
                    {
                        System.Console.WriteLine("Thank you for using our service. Have a nice day!");
                        Environment.Exit(0);
                    }
                        System.Console.WriteLine("Please choose from the following options:");
                        System.Console.WriteLine("1. Trainers");
                        System.Console.WriteLine("2. Bookings");
                        System.Console.WriteLine("3. Workout Generator (Please not this is using an API so it takes a while to load so please go to Program.cs and run where it is commeneted to see feature");
                        System.Console.WriteLine("4. Exit");
                }
                else if(choice =="3"){
                    System.Console.WriteLine("Please wait while we generate your workout plan...");
                    var workoutGenerator = new WorkoutGenerator();
                    var workoutPlan = workoutGenerator.GenerateWorkoutPlan();
                    Console.WriteLine("Here's your workout plan:");
                    foreach (var exercise in workoutPlan)
                    {
                        Console.WriteLine(exercise);
                    }
                }
                else if(choice =="4"){
                    Feedback.FeedbackUser();
                }
                else if (choice == "5")
                {
                    System.Console.WriteLine("Thank you for using our service. Have a nice day!");
                    Environment.Exit(0);
                }
            }
        }
    }
}



