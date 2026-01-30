using System;
using System.Collections.Generic;

public class Workout : ISavable
{
    public DateTime Date { get; set; }
    public List<Exercise> Exercises { get; set; }

    public Workout(DateTime date)
    {
        Date = date;
        Exercises = new List<Exercise>();
    }

    public void AddExercise(Exercise exercise)
    {
        Exercises.Add(exercise);
    }

    public string GetSummary()
    {
        return $"Workout on {Date.ToShortDateString()} ({Exercises.Count} exercises)";
    }
}
