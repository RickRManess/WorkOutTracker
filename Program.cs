using System;
using System.Collections.Generic;

namespace WorkOutTracker
{
    class Program
    {

        //enum for user choice of Crossfit lift
        public enum TypeCross
        {
            Burpees = 1,
            Thrusters,
            BoxJumps,
            Pullup
        }

        // enum for user choice of Weight Lift
        public enum TypeWeight
        {
            BenchPress = 1,
            Deadlift,
            MilitaryPress,
            Squats
        }

        static void Main(string[] args)
        {
            displayWelcomeScreen();
            int workoutChoice = Int32.Parse(Console.ReadLine());
            int userWorkoutChoice = 0;

            switch (workoutChoice)
            {
                case 1:
                    userWorkoutChoice = 1;
                    break;
                case 2:
                    userWorkoutChoice = 2;
                    break;
            }

            if (userWorkoutChoice == 1)
            {
                //user input to choose crossfit lift and store in variable 
                Console.WriteLine("Please select lift");
                Console.WriteLine("Burpees = 1  Thrusters = 2  Box Jumps = 3 Pullups = 4");
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

                // new list to save object as favorite
                var crosslist = new List<CrossFit>();

                //new crossfit object 
                var userCrossWorkout = new CrossFit();
                userCrossWorkout.CrossType = cross;
                userCrossWorkout.crossWeight = userCrossWeight;
                userCrossWorkout.crossSets = userCrossSets;
                userCrossWorkout.crossReps = userCrossReps;
                crosslist.Add(userCrossWorkout);


                //display Crossfit workout selection
                Console.WriteLine();
                Console.WriteLine("WOD Selection");
                Console.WriteLine(cross);
                Console.WriteLine(userCrossSets + "x" + userCrossReps);
                Console.WriteLine(userCrossWeight);

            }
            else
            {
                // user input to choose weight lift and store in variable
                Console.WriteLine("Please select lift");
                Console.WriteLine("Bench Press = 1  Deadlift = 2  Military Press = 3  Squats = 4");
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

                // new list to store workout as favorite 
                var weightList = new List<Weightlifting>();

                //new weightlifting object
                var userWorkout = new Weightlifting();
                userWorkout.LiftType = lift;
                userWorkout.liftWeight = userWeight;
                userWorkout.liftSets = userSets;
                userWorkout.liftReps = userReps;
                weightList.Add(userWorkout);

                //dispaly workout selection 
                Console.WriteLine();
                Console.WriteLine("Workout Selection");
                Console.WriteLine(lift);
                Console.WriteLine(userWeight + "lbs");
                Console.WriteLine(userSets + "x" + userReps);
            }

        }
        static void displayWelcomeScreen()
        {
            Console.WriteLine(" What type of workout do you want to do?");
            Console.WriteLine("CrossFit = 1   Weightlifting = 2");


        }

    }

}

