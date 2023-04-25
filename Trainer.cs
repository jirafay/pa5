namespace pa5
{



//create a trainer class that creates the get and set for Trainer ID, Trainer Name, Mailing Address, Trainer Email Address
    public class Trainer
    {
        //make it get and set functions not the shortcut

        private int TrainerID;
        private string TrainerName;
        private string MailingAddress;
        private string TrainerEmailAddress;

        public int GetTrainerID()
        {
            return TrainerID;
        }

        public void SetTrainerID(int value)
        {
            TrainerID = value;
        }

        public string GetTrainerName()
        {
            return TrainerName;
        }

        public void SetTrainerName(string value)
        {
            TrainerName = value;
        }

        public string GetMailingAddress()
        {
            return MailingAddress;
        }

        public void SetMailingAddress(string value)
        {
            MailingAddress = value;
        }

        public string GetTrainerEmailAddress()
        {
            return TrainerEmailAddress;
        }

        public void SetTrainerEmailAddress(string value)
        {
            TrainerEmailAddress = value;
        }

        public Trainer(int trainerID, string trainerName, string mailingAddress, string trainerEmailAddress)
        {
            TrainerID = trainerID;
            TrainerName = trainerName;
            MailingAddress = mailingAddress;
            TrainerEmailAddress = trainerEmailAddress;
        }

        public Trainer()
        {

        }

        public override string ToString()
        {

            return ($"TRAINER ID: {TrainerID} TRAINER NAME: {TrainerName} MAILING ADDRESS: {MailingAddress} EMAIL: {TrainerEmailAddress}");
        }
    }
}

