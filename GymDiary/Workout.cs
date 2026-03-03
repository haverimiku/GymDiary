using System;
using System.Collections.Generic;

namespace GymDiary
{
    public class Workout : WorkoutBase, ISavable
    {
        public List<Exercise> Exercises { get; set; }

        public Workout(DateTime date) : base(date)
        {
            Exercises = new List<Exercise>();
        }

        public void AddExercise(Exercise exercise)
        {
            Exercises.Add(exercise);
        }

        public override string GetSummary()
        {
            return $"Workout {Date:dd.MM.yyyy}";
        }
    }
}