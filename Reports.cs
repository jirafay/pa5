namespace pa5
{
    public class Reports
    {
        public static void IndividualCustomer(){
            //user provides customer email address and checks transactions.txt for all transactions with that email address and displays them
            string transactionsFile = "transactions.txt";
            string[] lines = File.ReadAllLines(transactionsFile);
            System.Console.WriteLine("Enter the customer's email address: ");
            string email = Console.ReadLine();
            int index = 0;
            bool found = false;
            foreach (string line in lines)
            {
                string[] fields = line.Split('#');
                if (fields[6] == email)
                {
                    found = true;
                    index = Array.IndexOf(lines, line);
                    System.Console.WriteLine($"Transaction ID: {fields[7]}");
                    System.Console.WriteLine($"Session ID: {fields[0]}");
                    System.Console.WriteLine($"Trainer ID: {fields[1]}");
                    System.Console.WriteLine($"Date: {fields[2]}");
                    System.Console.WriteLine($"Time: {fields[3]}");
                    System.Console.WriteLine($"Cost: {fields[4]}");
                    System.Console.WriteLine($"Customer Name: {fields[5]}");
                    System.Console.WriteLine($"Customer Email: {fields[6]}");
                    System.Console.WriteLine($"Status: {fields[8]}");
                }
            }
            if (found == false)
            {
                System.Console.WriteLine("No transactions found for that email address.");
            }

        }

        public static void HistoricalCustomer(){
            //list of all sessions sorted by customer then by date in transactions.txt
            string transactionsFile = "transactions.txt";
            string[] lines = File.ReadAllLines(transactionsFile);
            string[] sortedLines = lines.OrderBy(line => line.Split('#')[5]).ThenBy(line => line.Split('#')[2]).ToArray();
            foreach (string line in sortedLines)
            {
                string[] fields = line.Split('#');
                System.Console.WriteLine($"Transaction ID: {fields[7]}");
                System.Console.WriteLine($"Session ID: {fields[0]}");
                System.Console.WriteLine($"Trainer ID: {fields[1]}");
                System.Console.WriteLine($"Date: {fields[2]}");
                System.Console.WriteLine($"Time: {fields[3]}");
                System.Console.WriteLine($"Cost: {fields[4]}");
                System.Console.WriteLine($"Customer Name: {fields[5]}");
                System.Console.WriteLine($"Customer Email: {fields[6]}");
                System.Console.WriteLine($"Status: {fields[8]}");
            }
        }

        public static void HisoricalRevenue(){
            //list of revenue by month and by year
            //use the transactions.txt file to see which listings have been completed
            
            string transactionsFile = "transactions.txt";
            string[] lines = File.ReadAllLines(transactionsFile);
            string[] sortedLines = lines.OrderBy(line => line.Split('#')[3]).ToArray();
            double total = 0;
            double monthTotal = 0;
            string month = "";
            string year = "";

            foreach (string line in sortedLines)
            {
                string[] fields = line.Split('#');
                if (fields[8] == "Completed")
                {
                    total += double.Parse(fields[4]);
                    monthTotal += double.Parse(fields[4]);
                    //month = fields[3].Split('/')[0];
                    //year = fields[3].Split('/')[2];
                }
                else
                {
                    continue;
                }
                //if (month != fields[3].Split('/')[0])
                //{
                //    System.Console.WriteLine($"Total for {month}/{year}: {monthTotal}");
                //    monthTotal = 0;
                //    month = fields[3].Split('/')[0];
                //    year = fields[3].Split('/')[2];
                //}
            }

            System.Console.WriteLine($"Total for {month}: {monthTotal}");
            System.Console.WriteLine($"Total for all time: {total}");


            

            
        }
    }
}