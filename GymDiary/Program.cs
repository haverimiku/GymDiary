using System;
using System.IO;
using System.Text.Json;

class Program
{
    static void Main()
    {
        User user = new User("Test User");

        Workout workout = new Workout(DateTime.Now);
        Exercise benchPress = new Exercise("Bench Press");

        benchPress.AddSet(new Set(80, 8));
        benchPress.AddSet(new Set(80, 6));

        workout.AddExercise(benchPress);
        user.AddWorkout(workout);

        // Tulostus
        foreach (var w in user.Workouts)
        {
            Console.WriteLine(w.GetSummary());
            foreach (var e in w.Exercises)
            {
                Console.WriteLine($"  {e.Name}");
                foreach (var s in e.Sets)
                {
                    Console.WriteLine($"    {s}");
                }
            }
        }

        // Tallennus JSON-tiedostoon
        string json = JsonSerializer.Serialize(user, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText("gymdata.json", json);

        Console.WriteLine("\nData saved to gymdata.json");
    }
}
