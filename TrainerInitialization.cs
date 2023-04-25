namespace pa5
{
    public class TrainerInitialization
    {
        //create a trainerinitialization class that reads in trainers.txt and delimiter is # with the following fields: Trainer ID, Trainer Name, Mailing Address, Trainer Email Address. put this in a list of trainers
    
        public static List<Trainer> InitializeTrainers()
        {
            //read in trainers.txt

            //create a list of trainers

            //create a trainer object for each trainer in the trainers.txt file

            //add the trainer object to the list of trainers

            //return the list of trainers

            string filePath = "trainers.txt";
            string delimiter = "#";
            string[] fields;
            string line;
            int trainerID;
            string trainerName;
            string mailingAddress;
            string trainerEmailAddress;
            Trainer trainer;
            List<Trainer> trainers = new List<Trainer>();

            StreamReader reader = new StreamReader(filePath);

            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();
                fields = line.Split(delimiter.ToCharArray());
                trainerID = Convert.ToInt32(fields[0]);
                trainerName = fields[1];
                mailingAddress = fields[2];
                trainerEmailAddress = fields[3];
                trainer = new Trainer(trainerID, trainerName, mailingAddress, trainerEmailAddress);
                trainers.Add(trainer);
            }

            reader.Close();

            return trainers;
        }

    }
}