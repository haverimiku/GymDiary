using System;
using System.IO;
using System.Text.Json;
using System.Linq;

namespace GymDiary
{
    class Program
    {
        static string filePath = "gymdata.json";

        static void Main()
        {
            User user = LoadUser();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n=== GYM DIARY ===");
                Console.WriteLine("1. Add workout");
                Console.WriteLine("2. Show workouts");
                Console.WriteLine("3. Save");
                Console.WriteLine("4. Exit");
                Console.Write("Choose option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddWorkout(user);
                        break;

                    case "2":
                        ShowWorkouts(user);
                        break;

                    case "3":
                        SaveUser(user);
                        break;

                    case "4":
                        SaveUser(user);
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        static void AddWorkout(User user)
        {
            DateTime now = DateTime.Now;
            Workout workout = new Workout(now);

            Console.WriteLine($"\nCreating workout for {now:dd.MM.yyyy}");

            bool addingExercises = true;

            while (addingExercises)
            {
                Console.Write("Exercise name: ");
                string exerciseName = Console.ReadLine();

                Exercise exercise = new Exercise(exerciseName);
                bool addingSets = true;

                while (addingSets)
                {
                    Console.Write("Weight (kg): ");
                    double weight = double.Parse(Console.ReadLine());

                    Console.Write("Reps: ");
                    int reps = int.Parse(Console.ReadLine());

                    exercise.AddSet(new Set(weight, reps));

                    Console.Write("Add another set? (y/n): ");
                    if (Console.ReadLine().ToLower() != "y")
                        addingSets = false;
                }

                workout.AddExercise(exercise);

                Console.Write("Add another exercise? (y/n): ");
                if (Console.ReadLine().ToLower() != "y")
                    addingExercises = false;
            }

            user.AddWorkout(workout);
            Console.WriteLine("Workout saved to memory.");
        }

        static void ShowWorkouts(User user)
        {
            if (user.Workouts.Count == 0)
            {
                Console.WriteLine("No workouts found.");
                return;
            }

            var sortedWorkouts = user.Workouts
                .OrderByDescending(w => w.Date)
                .ToList();

            Console.WriteLine("\n=== WORKOUTS ===");

            for (int i = 0; i < sortedWorkouts.Count; i++)
            {
                Console.Write($"{i + 1}. ");
                PrintSummary(sortedWorkouts[i]);
            }

            Console.Write("Select workout number (0 to cancel): ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                if (choice > 0 && choice <= sortedWorkouts.Count)
                {
                    ShowSingleWorkout(sortedWorkouts[choice - 1]);
                }
            }
        }

        static void ShowSingleWorkout(Workout workout)
        {
            Console.WriteLine($"\n=== Workout {workout.Date:dd.MM.yyyy} ===");

            foreach (var exercise in workout.Exercises)
            {
                Console.WriteLine($"\n{exercise.Name}");

                foreach (var set in exercise.Sets)
                {
                    Console.WriteLine($"  {set.Weight} kg x {set.Reps}");
                }
            }
        }

        static void SaveUser(User user)
        {
            string json = JsonSerializer.Serialize(
                user,
                new JsonSerializerOptions { WriteIndented = true }
            );

            File.WriteAllText(filePath, json);
            Console.WriteLine("Data saved.");
        }

        static User LoadUser()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<User>(json) ?? new User("User");
            }

            return new User("User");
        }

        static void PrintSummary(ISavable savable)
        {
            Console.WriteLine(savable.GetSummary());
        }
    }
}