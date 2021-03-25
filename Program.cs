using System;
using System.Collections.Generic;
using WorkOutTracker.workout;

namespace WorkOutTracker
{
    class Program
    {
        public static SaveData Storage = new();

        static void Main(string[] args)
        {
            
            //Function to display welcome screen and workout style choice
            displayWelcomeScreen();
            int workoutChoice = Int32.Parse(Console.ReadLine());

            //initialized new list to store user created workouts as favorites
            var userFavoriteWorkouts = new List<WorkOut>();

            if (workoutChoice == 1)
            {
                //user input to choose crossfit lift and store in variable 
                Console.WriteLine("Please select lift");
                Console.WriteLine("Burpees = 1  Thrusters = 2  Box Jumps = 3 Pullups = 4");
                string userCross = Console.ReadLine();
                var cross = (CrossType)Convert.ToInt32(userCross); 

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
                var crossList = new List<CrossFit>();

                //new crossfit object 
                var userCrossWorkout = new CrossFit
                {
                    CrossType = cross,
                    Weight = userCrossWeight,
                    Sets = userCrossSets,
                    Reps = userCrossReps
                };
                crossList.Add(userCrossWorkout);
                userFavoriteWorkouts.Add(userCrossWorkout);
                Storage.CrossList.Add(new CrossFit());

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
                var lift = (WeightType)Convert.ToInt32(userLift);

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
                var userWorkout = new Weightlifting  
                {
                    LiftType = lift,
                    Weight = userWeight,
                    Sets = userSets,
                    Reps = userReps,
                    DateOfEntry = DateTime.Now

                };
                weightList.Add(userWorkout);
                userFavoriteWorkouts.Add(userWorkout);
                Storage.WeightList.Add(new Weightlifting());
                


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

