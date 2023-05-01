namespace pa5
{
    public class ListingInitialization
    {
        public static List<Listing> InitializeListings(){
            string filePath = "listings.txt";
            string delimiter = "#";
            string[] fields;
            string line;
            int listingID;
            int trainerID;
            string Day;
            string Month;
            string Year;
            string timeOfSession;
            int costOfSession;
            string listingTaken;
            Listing listing;
            List<Listing> listings = new List<Listing>();

            StreamReader reader = new StreamReader(filePath);

            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();
                fields = line.Split(delimiter);
                listingID = int.Parse(fields[0]);
                trainerID = int.Parse(fields[1]);
                Day = fields[2];
                Month = fields[3];
                Year = fields[4];
                timeOfSession = fields[5];
                costOfSession = int.Parse(fields[6]);
                listingTaken = fields[7];
                listing = new Listing(listingID, trainerID, Day, Month, Year, timeOfSession, costOfSession, listingTaken);
                listings.Add(listing);
            }

            reader.Close();

            return listings;
        }
    }
}