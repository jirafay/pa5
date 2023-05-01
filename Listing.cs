namespace pa5
{
    public class Listing
    {
        //create a listing class that creates the get and set for Listing ID, Trainer Name, Date of the Session, Time of the Session, Cost of the Session, If the listing has been taken
        private int ListingID;
        private int TrainerID;
        private string TimeOfSession;
        private int CostOfSession;
        private string ListingTaken;

        private string Day;
        private string Month;
        private string Year;

        public string GetDay()
        {
            return Day;
        }

        public void SetDay(string value)
        {
            Day = value;
        }

        public string GetMonth()
        {
            return Month;
        }

        public void SetMonth(string value)
        {
            Month = value;
        }

        public string GetYear()
        {
            return Year;
        }

        public void SetYear(string value)
        {
            Year = value;
        }

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



        public string GetTimeOfSession()
        {
            return TimeOfSession;
        }

        public void SetTimeOfSession(string value)
        {
            TimeOfSession = value;
        }

        public int GetCostOfSession()
        {
            return CostOfSession;
        }

        public void SetCostOfSession(int value)
        {
            CostOfSession = value;
        }

        public string GetListingTaken()
        {
            return ListingTaken;
        }

        public void SetListingTaken(string value)
        {
            ListingTaken = value;
        }

        public Listing(int listingID, int trainerID, string Day, string Month, string Year, string timeOfSession, int costOfSession, string listingTaken)
        {
            ListingID = listingID;
            TrainerID = trainerID;
            this.Day = Day;
            this.Month = Month;
            this.Year = Year;
            TimeOfSession = timeOfSession;
            CostOfSession = costOfSession;
            ListingTaken = listingTaken;
        }

        public Listing()
        {
        }

        public override string ToString()
        {
            return ($" LISTING ID: {ListingID} TRAINER ID: {TrainerID} DATE: {Day} {Month} {Year} TIME: {TimeOfSession} COST: ${CostOfSession} TAKEN: {ListingTaken}");
        }
    }
}