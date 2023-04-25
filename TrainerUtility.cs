
namespace pa5
{
    public class TrainerUtility
    {
        private static List<Trainer> trainers = new List<Trainer>();
    //Within the trainer section of the application the operator should be able to add, edit or delete the following information for a trainer: Trainer ID, Trainer Name, Mailing Address, Trainer Email Address. Trainers should be tracked in a trainers file to be used from one session to the next.  The file should be named trainers.txt and should be # delimited.

        public static void AddTrainer()
        {
            //add a trainer to the trainers.txt file
            //ask the user for the trainer id, trainer name, mailing address, trainer email address
            //create a trainer object
            //write the trainer object to the trainers.txt file
            
            //id = how many existing trainers + 1, but when we delete a trainer, we jump a number example: 1, 2, 3 but we delete 2 and add a new one, it will be 1, 3, 4

            string trainersFile = "trainers.txt";
            int nextId = 1;
            string[] lines = File.ReadAllLines(trainersFile);
            string lastLine = lines[lines.Length - 1];
            string[] fields = lastLine.Split('#');
            nextId= int.Parse(fields[0]) + 1;
            
            System.Console.WriteLine("Enter the trainer's name: ");
            string name = Console.ReadLine();

            System.Console.WriteLine("Enter the trainer's mailing address: ");
            string mailingAddress = Console.ReadLine();

            System.Console.WriteLine("Enter the trainer's email address: ");
            string emailAddress = Console.ReadLine();

            Trainer newTrainer = new Trainer(nextId, name, mailingAddress, emailAddress);

            trainers.Add(newTrainer);

            string fileBack = ($"{nextId}#{name}#{mailingAddress}#{emailAddress}");
            //write to trainers.txt on a new line with # delimiters

            File.AppendAllText(trainersFile, fileBack + Environment.NewLine);

            System.Console.WriteLine($"Trainer {name} has been added to the system.");
        }

        public static void EditTrainer()
        {
            //edit a trainer in the trainers.txt file
            //ask the user for the trainer id
            //search the trainers.txt file for the trainer id
            //if the trainer id is found, ask the user for the trainer name, mailing address, trainer email address
            //create a trainer object
            //write the trainer object to the trainers.txt file

            string trainersFile = "trainers.txt";
            string[] lines = File.ReadAllLines(trainersFile);
            System.Console.WriteLine("Enter the trainer's ID: ");
            int id = int.Parse(Console.ReadLine());
            string name = "";
            string mailingAddress = "";
            string emailAddress = "";
            int index = 0;
            bool found = false;

            foreach (string line in lines)
            {
                string[] fields = line.Split('#');
                if (int.Parse(fields[0]) == id)
                {
                    found = true;
                    index = Array.IndexOf(lines, line);
                    System.Console.WriteLine("Enter the trainer's name: ");
                    name = Console.ReadLine();

                    System.Console.WriteLine("Enter the trainer's mailing address: ");
                    mailingAddress = Console.ReadLine();

                    System.Console.WriteLine("Enter the trainer's email address: ");
                    emailAddress = Console.ReadLine();
                }
            }

            if (found == true)
            {
                lines[index] = ($"{id}#{name}#{mailingAddress}#{emailAddress}");
                File.WriteAllLines(trainersFile, lines);
                System.Console.WriteLine($"Trainer {name} has been edited.");
            }
            else
            {
                System.Console.WriteLine("Trainer not found.");
            }


        }

        public static void DeleteTrainer()
        {
            //delete a trainer in the trainers.txt file
            //ask the user for the trainer id
            //search the trainers.txt file for the trainer id
            //if the trainer id is found, delete the trainer from the trainers.txt file

            string trainersFile = "trainers.txt";
            string[] lines = File.ReadAllLines(trainersFile);
            System.Console.WriteLine("Enter the trainer's ID: ");
            int id = int.Parse(Console.ReadLine());
            string name = "";
            string mailingAddress = "";
            string emailAddress = "";
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

            if (found == true)
            {
                //set the line to blank and then write the file back

                lines[index] = "";
                File.WriteAllLines(trainersFile, lines);
                System.Console.WriteLine($"Trainer {name} has been deleted.");

            }
            else
            {
                System.Console.WriteLine("Trainer not found.");
            }


        }

        public static void DisplayTrainers()
        {
            //display all trainers in the trainers.txt file
            //if there is a blank line skip it
            
            string trainersFile = "trainers.txt";
            string[] lines = File.ReadAllLines(trainersFile);
            System.Console.WriteLine("Trainer ID\tTrainer Name\tMailing Address\tTrainer Email Address");
            foreach (string line in lines)
            {
                string[] fields = line.Split('#');
                if (fields[0] != "")
                {
                    System.Console.WriteLine($"{fields[0]}\t{fields[1]}\t{fields[2]}\t{fields[3]}");
                }
            }

        }


    }
}