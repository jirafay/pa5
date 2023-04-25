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
            string dateOfSession;
            string timeOfSession;
            double costOfSession;
            bool listingTaken;
            Listing listing;
            List<Listing> listings = new List<Listing>();

            StreamReader reader = new StreamReader(filePath);

            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();
                fields = line.Split(delimiter);
                listingID = int.Parse(fields[0]);
                trainerID = int.Parse(fields[1]);
                dateOfSession = fields[2];
                timeOfSession = fields[3];
                costOfSession = double.Parse(fields[4]);
                listingTaken = bool.Parse(fields[5]);
                listing = new Listing(listingID, trainerID, dateOfSession, timeOfSession, costOfSession, listingTaken);
                listings.Add(listing);
            }

            reader.Close();

            return listings;
        }
    }
}