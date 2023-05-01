using pa5;
using System;




WelcomeDisp();
Menu.mainMenu();



//uncomment the code below to run the WorkoutGernerator ********************************

// var workoutGenerator = new WorkoutGenerator();
// var workoutPlan = workoutGenerator.GenerateWorkoutPlan();
// Console.WriteLine("Here's your workout plan:");
// foreach (var exercise in workoutPlan)
// {
//     Console.WriteLine(exercise);
// }

//***************************************************************************************


static void WelcomeDisp()

     {

        Console.Clear();

        bool show = true;

        do

        {

            while (!Console.KeyAvailable)

            {

                string alert = @"                                                                                ██╗   ██╗ █████╗      ██████╗██╗   ██╗███╗   ███╗
                                                                                ██║   ██║██╔══██╗    ██╔════╝╚██╗ ██╔╝████╗ ████║
                                                                                ██║   ██║███████║    ██║  ███╗╚████╔╝ ██╔████╔██║
                                                                                ██║   ██║██╔══██║    ██║   ██║ ╚██╔╝  ██║╚██╔╝██║
                                                                                ╚██████╔╝██║  ██║    ╚██████╔╝  ██║   ██║ ╚═╝ ██║
                                                                                ╚═════╝ ╚═╝  ╚═╝     ╚═════╝   ╚═╝   ╚═╝     ╚═╝
                                                 
                Press esc to stop                                                                                                                                                                                                                                             

                ";

                Console.ForegroundColor = ConsoleColor.DarkBlue;

                Console.ForegroundColor = show ? ConsoleColor.DarkBlue: ConsoleColor.DarkRed; show = !show;

                Console.WriteLine(alert); Console.ForegroundColor = ConsoleColor.White; Thread.Sleep(800);

                Console.Clear();

            }

        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

            Console.Clear();
    Console.ResetColor();
}
