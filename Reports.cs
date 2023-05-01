namespace pa5
{
    public class Reports
    {
        public static void IndividualCustomer()
        {
            //user provides customer email address and checks transactions.txt for all transactions with that email address and displays them
            string transactionsFile = "transactions.txt";
            string[] lines = File.ReadAllLines(transactionsFile);
            System.Console.WriteLine("Would you like to save this report to a file? (y/n)");
            string answer = Console.ReadLine();
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
                    if (answer == "y")
                    {
                        string individualCustomerFile = "individualcustomer.txt";
                        StreamWriter sw = new StreamWriter(individualCustomerFile);
                        sw.WriteLine($"{fields[7]}#{fields[0]}#{fields[1]}#{fields[2]}#{fields[3]}#{fields[4]}#{fields[5]}#{fields[6]}#{fields[8]}");
                        sw.Close();
                    }
                }
                if (found == false)
                {
                    System.Console.WriteLine("No transactions found for that email address.");
                }
                //ask the user if they want to save the report to a file
                //write to the file individualcustomer.txt of the transactions with that email address

                else
                {
                    return;
                }

            }
        }
        public static void HistoricalCustomer()
        {
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
                //ask the user if they want to save the report to a file
                System.Console.WriteLine("Would you like to save this report to a file? (y/n)");
                string answer = Console.ReadLine();
                //write to the file historicalcustomer.txt
                if (answer == "y")
                {
                    string historicalCustomerFile = "historicalcustomer.txt";
                    File.WriteAllLines(historicalCustomerFile, sortedLines);
                }
                else
                {
                    return;
                }
        }

        public static void HistoricalRevenue()
        {
                //list of revenue by month and by year
                //use the transactions.txt file to see which listings have been completed

                string transactionsFile = "transactions.txt";
                string[] lines = File.ReadAllLines(transactionsFile);
                string[] sortedLines = lines.OrderBy(line => line.Split('#')[2]).ToArray();
                double total = 0;
                double monthTotal = 0;
                string month = "";
                string year = "";


                //loop through the sorted lines and add up the total for each month and year
                //cost is field 6
                //month is field 2
                //year is field 4
                //show the total for each month and each year
                foreach (string line in sortedLines)
                {
                    string[] fields = line.Split('#');
                    if (fields[2] == month && fields[4] == year)
                    {
                        monthTotal += Convert.ToDouble(fields[6]);
                    }
                    else
                    {
                        if (month != "")
                        {
                            System.Console.WriteLine($"Total for {month} {year}: {monthTotal}");
                        }
                        monthTotal = Convert.ToDouble(fields[6]);
                        month = fields[2];
                        year = fields[4];
                    }
                    total += Convert.ToDouble(fields[6]);
                    //show the yearly total aswell
                }
                //show the total for each year 
                //cost is field 6
                //year is field 4


                foreach (string line in sortedLines)
                {
                    string[] fields = line.Split('#');
                    if (fields[4] == year)
                    {
                        monthTotal += Convert.ToDouble(fields[6]);
                    }
                    else
                    {
                        System.Console.WriteLine($"Total for {year}: {monthTotal}");
                        monthTotal = Convert.ToDouble(fields[6]);
                        year = fields[4];
                    }
                    total += Convert.ToDouble(fields[6]);
                    //show the yearly total aswell
                }

                System.Console.WriteLine($"Total for {month} {year}: {monthTotal}");
                System.Console.WriteLine($"Total for all time: {total}");


                
                //ask the user if they want to save the report to a file
                System.Console.WriteLine("Would you like to save this report to a file? (y/n)");
                string answer = Console.ReadLine();
                //write to the file historicalrevenue.txt
                if (answer == "y")
                {
                    string historicalRevenueFile = "historicalrevenue.txt";
                    File.WriteAllLines(historicalRevenueFile, sortedLines);
                }
                else
                {
                    return;
                }
        }
    }
}