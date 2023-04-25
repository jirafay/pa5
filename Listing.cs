namespace pa5
{
    public class Listing
    {
        //create a listing class that creates the get and set for Listing ID, Trainer Name, Date of the Session, Time of the Session, Cost of the Session, If the listing has been taken
        private int ListingID;
        private int TrainerID;
        private string DateOfSession;
        private string TimeOfSession;
        private double CostOfSession;
        private bool ListingTaken;

        public int GetListingID()
        {
            return ListingID;
        }

        public void SetListingID(int value)
        {
            ListingID = value;
        }

        public int GetTrainerID()
        {
            return TrainerID;
        }

        public void SetTrainerID(int value)
        {
            TrainerID = value;
        }

        public string GetDateOfSession()
        {
            return DateOfSession;
        }

        public void SetDateOfSession(string value)
        {
            DateOfSession = value;
        }

        public string GetTimeOfSession()
        {
            return TimeOfSession;
        }

        public void SetTimeOfSession(string value)
        {
            TimeOfSession = value;
        }

        public double GetCostOfSession()
        {
            return CostOfSession;
        }

        public void SetCostOfSession(double value)
        {
            CostOfSession = value;
        }

        public bool GetListingTaken()
        {
            return ListingTaken;
        }

        public void SetListingTaken(bool value)
        {
            ListingTaken = value;
        }

        public Listing(int listingID, int trainerID, string dateOfSession, string timeOfSession, double costOfSession, bool listingTaken)
        {
            ListingID = listingID;
            TrainerID = trainerID;
            DateOfSession = dateOfSession;
            TimeOfSession = timeOfSession;
            CostOfSession = costOfSession;
            ListingTaken = listingTaken;
        }

        public Listing()
        {
        }

        public override string ToString()
        {
            return ($" LISTING ID: {ListingID} TRAINER ID: {TrainerID} DATE: {DateOfSession} TIME: {TimeOfSession} COST: ${CostOfSession} TAKEN: {ListingTaken}");
        }
    }
}