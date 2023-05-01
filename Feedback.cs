namespace pa5
{
    public class Feedback{
        public static void FeedbackUser(){
            //user enters the trainers id and writes feedback
            Console.WriteLine("Enter the trainer's ID: ");
            int trainerID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the feedback: ");
            string feedback = Console.ReadLine();
            System.Console.WriteLine("Enter a rating from 1-5: ");
            int rating = Convert.ToInt32(Console.ReadLine());
            //writes the feeback to feedback.txt as the format trainerID#feedback
            using (StreamWriter sw = File.AppendText("feedback.txt"))
            {
                sw.WriteLine(trainerID + "#" + feedback + "#" + rating);
            }

        }
    
        public static void ViewFeedback(){
            //reads the feedback.txt file and displays the feedback
            string[] lines = File.ReadAllLines("feedback.txt");
            foreach (string line in lines)
            {
                string[] words = line.Split('#');
                System.Console.WriteLine("Trainer ID: " + words[0]);
                System.Console.WriteLine("Feedback: " + words[1]);
                System.Console.WriteLine("Rating: " + words[2]);
            }
        }
    }
}