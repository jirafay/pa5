namespace pa5
{
    public class ListingUtility
    {
        private static List<Listing> listings = new List<Listing>();
        public static void AddListing()
        {
            //add a listing to the listings.txt file
            //ask the user for the listing id, trainer id, date of session, time of session, cost of session, if the listing has been taken
            //create a listing object
            //write the listing object to the listings.txt file

            string listingsFile = "listings.txt";
            int nextId = 1;
            string[] lines = File.ReadAllLines(listingsFile);
            string lastLine = lines[lines.Length - 1];
            string[] fields = lastLine.Split('#');
            nextId= int.Parse(fields[0]) + 1;

            System.Console.WriteLine("Enter the trainer's ID: ");
            int trainerId = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter the date of the session: ");
            string date = Console.ReadLine();

            System.Console.WriteLine("Enter the time of the session: ");
            string time = Console.ReadLine();

            System.Console.WriteLine("Enter the cost of the session: ");
            double cost = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter if the session has been taken: ");
            bool taken = bool.Parse(Console.ReadLine());

            Listing newListing = new Listing(nextId, trainerId, date, time, cost, taken);

            listings.Add(newListing);

            string fileBack = ($"{nextId}#{trainerId}#{date}#{time}#{cost}#{taken}");

            File.AppendAllText(listingsFile, fileBack + Environment.NewLine);

            System.Console.WriteLine($"Listing {nextId} has been added to the system.");

            
        }

        public static void EditListing()
        {
            //edit a listing in the listings.txt file
            //ask the user for the listing id
            //search the listings.txt file for the listing id
            //if the listing id is found, ask the user for the trainer id, date of session, time of session, cost of session, if the listing has been taken
            //create a listing object
            //write the listing object to the listings.txt file

            string listingsFile = "listings.txt";
            string[] lines = File.ReadAllLines(listingsFile);
            System.Console.WriteLine("Enter the listing's ID: ");
            int id = int.Parse(Console.ReadLine());
            int trainerId = 0;
            string date = "";
            string time = "";
            double cost = 0;
            bool taken = false;
            int index = 0;
            bool found = false;

            foreach (string line in lines)
            {
                string[] fields = line.Split('#');
                if (int.Parse(fields[0]) == id)
                {
                    found = true;
                    index = Array.IndexOf(lines, line);
                    System.Console.WriteLine("Enter the trainer's ID: ");
                    trainerId = int.Parse(Console.ReadLine());

                    System.Console.WriteLine("Enter the date of the session: ");
                    date = Console.ReadLine();

                    System.Console.WriteLine("Enter the time of the session: ");
                    time = Console.ReadLine();

                    System.Console.WriteLine("Enter the cost of the session: ");
                    cost = double.Parse(Console.ReadLine());

                    System.Console.WriteLine("Enter if the session has been taken: ");
                    taken = bool.Parse(Console.ReadLine());
                }
            }

            if (found)
            {
                Listing newListing = new Listing(id, trainerId, date, time, cost, taken);
                listings.Add(newListing);
                string fileBack = ($"{id}#{trainerId}#{date}#{time}#{cost}#{taken}");
                lines[index] = fileBack;
                File.WriteAllLines(listingsFile, lines);
                System.Console.WriteLine($"Listing {id} has been edited.");
            }
            else
            {
                System.Console.WriteLine($"Listing {id} was not found.");
            }
        }

        public static void DeleteListing()
        {
            //delete a listing in the listings.txt file
            //ask the user for the listing id
            //search the listings.txt file for the listing id
            //if the listing id is found, delete the listing from the listings.txt file

            string listingsFile = "listings.txt";
            string[] lines = File.ReadAllLines(listingsFile);
            System.Console.WriteLine("Enter the listing's ID: ");
            int id = int.Parse(Console.ReadLine());
            int index = 0;
            bool found = false;

            foreach (string line in lines)
            {
                string[] fields = line.Split('#');
                if (int.Parse(fields[0]) == id)
                {
                    found = true;
                    index = Array.IndexOf(lines, line);
                }
            }

            if (found==true)
            {
                lines[index] = "";
                File.WriteAllLines(listingsFile, lines);
                System.Console.WriteLine($"Listing {id} has been deleted.");
            }
            else
            {
                System.Console.WriteLine($"Listing {id} was not found.");
            }


        }

        public static void DisplayListings()
        {
            string listingsFile = "listings.txt";
            string[] lines = File.ReadAllLines(listingsFile);
            System.Console.WriteLine("Listing ID\tTrainer ID\tDate\tTime\tCost\tTaken");
            foreach (string line in lines)
            {
                //if line is empty, skip it
                if (line == "")
                {
                    continue;
                }
                string[] fields = line.Split('#');
                System.Console.WriteLine($"{fields[0]}\t{fields[1]}\t{fields[2]}\t{fields[3]}\t{fields[4]}\t{fields[5]}");


            }
           
        }
    }
}