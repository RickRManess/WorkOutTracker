using System;

namespace WorkOutTracker
{
    class Program
    {
        //enum for user choice of Crossfit lift
        public enum TypeCross
        {
            Burpees,
            Thrusters,
            BoxJumps,
            Pullup
        }


        // enum for user choice of Weight Lift
        public enum TypeWeight
        {
            BenchPress,
            Deadlift,
            MilitaryPress,
            Squats
        }

        static void Main(string[] args)
        {
            //user input to choose crossfit lift and store in variable 
            Console.WriteLine("Please select lift");
            string userCross = Console.ReadLine();
            var cross = (TypeCross)Convert.ToInt32(userCross);

            //user input to choose crossfit weight and store in variable
            Console.WriteLine("Please select weight for lift");
            int userCrossWeight = Int32.Parse(Console.ReadLine());

            //user input to choose crossfit sets and store in variable
            Console.WriteLine("Please enter number of sets");
            var userCrossSets = Int32.Parse(Console.ReadLine());

            //user input to choose crossfit reps and store in variable 
            Console.WriteLine("Please enter number of reps");
            var userCrossReps = Int32.Parse(Console.ReadLine());

            //new list to store userinput as a favorite workout
            var userCrossWorkout = new CrossFit();
            userCrossWorkout.CrossType = cross;
            userCrossWorkout.crossWeight = userCrossWeight;
            userCrossWorkout.crossSets = userCrossSets;
            userCrossWorkout.crossReps = userCrossReps;


            //display Crossfit workout selection
            Console.WriteLine();
            Console.WriteLine("WOD Selection");
            Console.WriteLine(cross);
            Console.WriteLine(userCrossSets + userCrossReps);
            Console.WriteLine(userCrossWeight);
            
            // user input to choose weight lift and store in variable
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

            //new list to store userinput as a favorite workout 
            var userWorkout = new Weightlifting();
            userWorkout.LiftType = lift;
            userWorkout.liftWeight = userWeight;
            userWorkout.liftSets = userSets;
            userWorkout.liftReps = userReps;

            //dispaly workout selection 
            Console.WriteLine();
            Console.WriteLine("Workout Selection");
            Console.WriteLine(lift);
            Console.WriteLine(userWeight + "lbs");
            Console.WriteLine(userSets + "x" + userReps);


        }

    }

}

