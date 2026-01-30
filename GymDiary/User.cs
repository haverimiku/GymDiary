using System.Collections.Generic;

public class User
{
    public string Name { get; set; }
    public List<Workout> Workouts { get; set; }

    public User(string name)
    {
        Name = name;
        Workouts = new List<Workout>();
    }

    public void AddWorkout(Workout workout)
    {
        Workouts.Add(workout);
    }
}
