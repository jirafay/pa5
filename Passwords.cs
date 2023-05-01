namespace pa5
{
    public class Passwords
    {
        public void CreatePassword(){
            //user enters the trainers id and writes feedback
            Console.WriteLine("Enter the password you would like to add that trainers can use to access: ");
            string password = Console.ReadLine();
            //writes the feeback to feedback.txt as the format trainerID#feedback
            using (StreamWriter sw = File.AppendText("trainerpasswords.txt"))
            {
                sw.WriteLine(password);
            }

        }

       
    }
}