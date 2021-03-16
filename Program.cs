using System;

namespace WorkOutTracker
{
    class Program
    {   // enum for user input workout lift
        public enum TypeWeight
        {
            BenchPress,
            Deadlift,
            MilitaryPress,
            Squats
        }

        static void Main(string[] args)
        {    // User input to choose workout lift and store in variable
            Console.WriteLine("Please select lift");
            string userLift = Console.ReadLine();
            var lift = (TypeWeight)Convert.ToInt32(userLift);


            //user input to choose workout weight and store in variable
            Console.WriteLine("Please enter weight for lift");
            int userWeight = Int32.Parse(Console.ReadLine());

            //user input to choose workout sets and store in variable
            Console.WriteLine("Please enter number of sets");
            int userSets = Int32.Parse(Console.ReadLine());

            //user input to choose workout reps and store in variable 
            Console.WriteLine("Please enter number of reps");
            int userReps = Int32.Parse(Console.ReadLine());

            //new list to store userinput as a workout 
            var userWorkout = new Weightlifting();
            userWorkout.LiftType = lift;
            userWorkout.liftWeight = userWeight;
            userWorkout.liftSets = userSets;
            userWorkout.liftReps = userReps;

            //dispaly workout selection 
            Console.WriteLine();
            Console.WriteLine(lift);
            Console.WriteLine(userWeight + "lbs");
            Console.WriteLine(userSets + "x" + userReps);
       


        }

    }

}

