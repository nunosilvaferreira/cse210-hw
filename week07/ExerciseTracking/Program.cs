using System;
using System.Collections.Generic;

namespace ExerciseTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Activity> activities = new List<Activity>
            {
                new Running(new DateTime(2023, 11, 3), 30, 3.0),
                new Cycling(new DateTime(2023, 11, 3), 30, 9.7),
                new Swimming(new DateTime(2023, 11, 3), 30, 20)
            };

            foreach (var activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}   {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
    }
}