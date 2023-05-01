namespace pa5
{
    public class BookingsUtility
    {

        public static List<Bookings> transactions = new List<Bookings>();
        //create a method to display all available sessions

        public static void DisplayBookings()
        {
            string listingsFile = "listings.txt";
            string[] lines = File.ReadAllLines(listingsFile);
            foreach (string line in lines)
            {

                //display all listings that are not taken
                //if there is no available sessions, display a message to the user
                //if there is a blank line in the file, skip it
                
                string[] fields = line.Split('#');
                if (fields[0] == "")
                {
                    continue;
                }
                if (fields[7] == "True")
                {

                    //when displaying the trainer id, display the trainer's name from the trainers.txt file

                    System.Console.WriteLine($"Listing ID: {fields[0]}");
                    string trainersFile = "trainers.txt";
                    string[] lines2 = File.ReadAllLines(trainersFile);
                    foreach (string line2 in lines2)
                    {
                        string[] fields2 = line2.Split('#');
                        if (fields2[0] == "")
                        {
                            continue;
                        }
                        if (int.Parse(fields[1]) == int.Parse(fields2[0]))
                        {
                            System.Console.WriteLine($"Trainer Name: {fields2[1]}");
                        }
                    }
                    System.Console.WriteLine($"Trainer ID: {fields[1]}");
                    System.Console.WriteLine($"Date: {fields[2]} {fields[3]} {fields[4]}");
                    System.Console.WriteLine($"Time: {fields[5]}");
                    System.Console.WriteLine($"Cost: {fields[6]}");
                    System.Console.WriteLine($"Taken: {fields[7]}");
                    System.Console.WriteLine();
                }
                
                
            }
        }
    

        //book a session
        //sessions should be tracked in the transactions.txt file
        //session should include the listing id, the trainer id, the date, the time, the cost, and the client id

        public static void BookSession()
        {
            //ask the user for the listing id
            //search the listings.txt file for the listing id
            //if the listing id is found, ask the user for the client id
            //create a transaction object
            //write the transaction object to the transactions.txt file
            //set the listing to taken

            string listingsFile = "listings.txt";
            string[] lines = File.ReadAllLines(listingsFile);
            System.Console.WriteLine("Enter the listing's ID: ");
            int SessionID = int.Parse(Console.ReadLine());
            //ask the customer for ther name and email
            //pull the listing id, trainer id, date, time, and cost from the listings.txt file
            //create a transaction object
            //write the transaction object to the transactions.txt file
            //set the listing to taken
            //create a transaction id 

            string name = "";
            string email = "";
            int trainerID = 0;
            string day = "";
            string month = "";
            string year= "";
            string time = "";
            double cost = 0;
            int index = 0;
            bool found = false;
            int transactionId = 0;
            string status = "Booked";

            foreach (string line in lines)
            {
                string[] fields = line.Split('#');
                if (int.Parse(fields[0]) == SessionID)
                {
                    found = true;
                    index = Array.IndexOf(lines, line);
                    trainerID = int.Parse(fields[1]);
                    day = fields[2];
                    month= fields[3];
                    year = fields[4];
                    time = fields[5];
                    cost = double.Parse(fields[6]);
                    transactionId = transactions.Count + 1;
                    status = "Booked";
                }
            }

            if (found == true)
            {
                System.Console.WriteLine("Enter your name: ");
                name = Console.ReadLine();
                System.Console.WriteLine("Enter your email: ");
                email = Console.ReadLine();
                //create a transaction object
                //write the transaction object to the transactions.txt file
                //set the listing to taken
                string trainersFile = "trainers.txt";
                string[] lines2 = File.ReadAllLines(trainersFile);
                string trainerName = "";
                foreach (string line2 in lines2)
                {
                    string[] fields2 = line2.Split('#');
                    if (int.Parse(fields2[0]) == trainerID)
                    {
                        trainerName = fields2[1];
                    }
                }
                Bookings transaction = new Bookings(transactionId, SessionID, name, email, day, month,year, time, trainerName, cost,trainerID, status);
                transactions.Add(transaction);
                //wrtie the transaction object to the transactions.txt file in the following format: listing id#trainer id#date#time#cost#client name#client email
                string fileBack= ($"{SessionID}#{trainerID}#{day}#{month}#{year}#{time}#{cost}#{name}#{email}#{transactionId}#{status}");
                File.AppendAllText("transactions.txt", fileBack + Environment.NewLine);
                //find the name of the trainer based on the trainer id and create a variable to hold the trainer's name
                //display a message to the user that they have successfully booked a session with the trainer on the date at the time for the cost

                System.Console.WriteLine($"You have successfully booked a session with {trainerName} on {day} {month} {year} at {time} for {cost}.");

                //set the listing to taken
                lines[index] = $"{SessionID}#{trainerID}#{day}#{month}#{year}#{time}#{cost}#{true}";
                File.WriteAllLines(listingsFile, lines);


            }
            else
            {
                System.Console.WriteLine("Session not found.");
            }
        }  
        public static void UpdateSession(){
            //display all transactions
            //ask the user for the transaction id (last field in the transactions.txt file)
            //search the listings.txt file for the listing id
            //allow the user to update if it is taken or not
            //let them either make it completed, cancelled, or no show

            string transactionsFile = "transactions.txt";
            string[] lines = File.ReadAllLines(transactionsFile);
            bool found = false;
            int index = 0;
            string name = "";
            string emailAddress = "";
            string status = "";
            int SessionID=0;
            int trainerID=0;
            string day="";
            string month="";
            string year="";
            string time="";
            double cost=0;
            foreach (string line in lines)
            {
                string[] fields = line.Split('#');
                if (fields[0] == "")
                {
                    continue;
                }
                System.Console.WriteLine($"Transaction ID: {fields[9]}");
                System.Console.WriteLine($"Listing ID: {fields[0]}");
                System.Console.WriteLine($"Trainer ID: {fields[1]}");
                System.Console.WriteLine($"Date: {fields[2]} {fields[3]} {fields[4]}");
                System.Console.WriteLine($"Time: {fields[5]}");
                System.Console.WriteLine($"Cost: {fields[6]}");
                System.Console.WriteLine($"Client Name: {fields[7]}");
                System.Console.WriteLine($"Client Email: {fields[8]}");
                System.Console.WriteLine($"Status: {fields[10]}");
                System.Console.WriteLine();
            }
            System.Console.WriteLine("Enter the transaction ID: ");
            int transactionId = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the new status: ");
            string newStatus = Console.ReadLine();

            string transactionsFile1 = "transactions.txt";
            string[] lines1 = File.ReadAllLines(transactionsFile1);

            //using this new transaction id, find the transaction in the transactions.txt file and change the status to completed, cancelled, or no show
            for(int i = 0; i < lines1.Length; i++)
            {
                string line = lines1[i];
                string[] fields = line.Split('#');
                if (fields.Length >= 11 && int.Parse(fields[9]) == transactionId)
                {
                    SessionID = int.Parse(fields[0]);
                    trainerID = int.Parse(fields[1]);
                    day = fields[2];
                    month = fields[3];
                    year = fields[4];
                    time = fields[5];
                    cost = double.Parse(fields[6]);
                    name = fields[7];
                    emailAddress = fields[8];
                    status = newStatus;
                    //write the transaction object to the transactions.txt file at the same index
                    lines1[i] = ($"{SessionID}#{trainerID}#{day}#{month}#{year}#{time}#{cost}#{name}#{emailAddress}#{transactionId}#{status}");
                    File.WriteAllLines(transactionsFile1, lines1);
                    break;
                }   
            }
            Console.WriteLine("Transaction updated.");
        }
    }
}


