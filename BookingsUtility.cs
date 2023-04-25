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
                if (bool.Parse(fields[5]) == false)
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
                    System.Console.WriteLine($"Date: {fields[2]}");
                    System.Console.WriteLine($"Time: {fields[3]}");
                    System.Console.WriteLine($"Cost: {fields[4]}");
                    System.Console.WriteLine($"Taken: {fields[5]}");
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
            string date = "";
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
                    date = fields[2];
                    time = fields[3];
                    cost = double.Parse(fields[4]);
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

                Bookings transaction = new Bookings(SessionID, trainerID, date, time, cost, name, email, transactionId, status);
                transactions.Add(transaction);
                //wrtie the transaction object to the transactions.txt file in the following format: listing id#trainer id#date#time#cost#client name#client email
                string fileBack= ($"{SessionID}#{trainerID}#{date}#{time}#{cost}#{name}#{email}#{transactionId}#{status}");
                File.AppendAllText("transactions.txt", fileBack + Environment.NewLine);
                //find the name of the trainer based on the trainer id and create a variable to hold the trainer's name
                //display a message to the user that they have successfully booked a session with the trainer on the date at the time for the cost
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
                System.Console.WriteLine($"You have successfully booked a session with {trainerName} on {date} at {time} for {cost}.");

                //set the listing to taken
                lines[index] = $"{SessionID}#{trainerID}#{date}#{time}#{cost}#{true}";
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
            string date="";
            string time="";
            double cost=0;
            foreach (string line in lines)
            {
                string[] fields = line.Split('#');
                if (fields[0] == "")
                {
                    continue;
                }
                System.Console.WriteLine($"Transaction ID: {fields[7]}");
                System.Console.WriteLine($"Listing ID: {fields[0]}");
                System.Console.WriteLine($"Trainer ID: {fields[1]}");
                System.Console.WriteLine($"Date: {fields[2]}");
                System.Console.WriteLine($"Time: {fields[3]}");
                System.Console.WriteLine($"Cost: {fields[4]}");
                System.Console.WriteLine($"Client Name: {fields[5]}");
                System.Console.WriteLine($"Client Email: {fields[6]}");
                System.Console.WriteLine($"Status: {fields[8]}");
                System.Console.WriteLine();
            }

            System.Console.WriteLine("Enter the transaction ID: ");
            int transactionId = int.Parse(Console.ReadLine());
            foreach (string line in lines)
            {
                string[] fields = line.Split('#');
                if (int.Parse(fields[7]) == transactionId)
                {
                    found = true;
                    index = Array.IndexOf(lines, line);
                    name = fields[5];
                    emailAddress = fields[6];
                    status = fields[8];
                    SessionID = int.Parse(fields[0]);
                    trainerID = int.Parse(fields[1]);
                    date = fields[2];
                    time = fields[3];
                    cost = double.Parse(fields[4]);

                }
                
            }

            if (found == true)
            {
                
                lines[index] = ($"{SessionID}#{trainerID}#{date}#{time}#{cost}#{name}#{emailAddress}#{transactionId}#{status}");
                File.WriteAllLines(transactionsFile, lines);
                System.Console.WriteLine("Enter the new status: ");
                string newStatus = Console.ReadLine();
                string fileBack= ($"{SessionID}#{trainerID}#{date}#{time}#{cost}#{name}#{emailAddress}#{transactionId}#{newStatus}");
                //cahnge the status of the transaction to the new status and write it to the transactions.txt file on the same line
                File.AppendAllText("transactions.txt", fileBack + Environment.NewLine);
                System.Console.WriteLine("Status updated.");

        




        }    
    }
}
}


