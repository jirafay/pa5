namespace pa5
{
    public class Bookings
    {
        private int SessionID;
        private string CustomerName;
        private string CustomerEmail;
        private string TrainingDate;
        private string TrainingTime;
        private string TrainerName;
        private int TransactionID;



        private double Cost;

        public int GetTransactionID()
        {
            return TransactionID;
        }


        public void SetTransactionID(int value)
        {
            TransactionID = value;
        }

        public string GetTrainingTime()
        {
            return TrainingTime;
        }

        public void SetTrainingTime(string value)
        {
            TrainingTime = value;
        }

        public double GetCost()
        {
            return Cost;
        }

        public void SetCost(double value)
        {
            Cost = value;
        }

        private int TrainerID;
        private string Status;
        private string date;
        private string time;
        private double cost;
        private string? name;
        private string? email;

        public int GetTrainerID()
        {
            return TrainerID;
        }

        public void SetTrainerID(int value)
        {
            TrainerID = value;
        }

        public int GetSessionID()
        {
            return SessionID;
        }

        public void SetSessionID(int value)
        {
            SessionID = value;
        }

        public string GetCustomerName()
        {
            return CustomerName;
        }

        public void SetCustomerName(string value)
        {
            CustomerName = value;
        }

        public string GetCustomerEmail()
        {
            return CustomerEmail;
        }

        public void SetCustomerEmail(string value)
        {
            CustomerEmail = value;
        }

        public string GetTrainingDate()
        {
            return TrainingDate;
        }

        public void SetTrainingDate(string value)
        {
            TrainingDate = value;
        }

        public string GetTrainerName()
        {
            return TrainerName;
        }

        public void SetTrainerName(string value)
        {
            TrainerName = value;
        }

        public string GetStatus()
        {
            return Status;
        }

        public void SetStatus(string value)
        {
            Status = value;
        }

        public Bookings(int TranscationID, int sessionID, string customerName, string customerEmail, string trainingDate, string trainingTime, string trainerName, double cost, int trainerID, string status)
        {
            TransactionID = TranscationID;
            SessionID = sessionID;
            CustomerName = customerName;
            CustomerEmail = customerEmail;
            TrainingDate = trainingDate;
            TrainingTime = trainingTime;
            TrainerName = trainerName;
            Cost = cost;
            TrainerID = trainerID;
            Status = status;
        }

        public Bookings()
        {

        }

        public Bookings(int sessionID, int trainerID, string date, string time, double cost, string? name, string? email, int transactionId, string status)
        {
            SessionID = sessionID;
            TrainerID = trainerID;
            this.date = date;
            this.time = time;
            this.cost = cost;
            this.name = name;
            this.email = email;
            TransactionID = transactionId;
            Status = status;
        }

        public override string ToString()
        {
            return ($"{SessionID}#{CustomerName}#{CustomerEmail}#{TrainingDate}#{TrainerName}#{Status}#{TransactionID}");
        }

    }
}