using System;
using System.Collections.Generic;

namespace GymDiary
{
    // Workout perii WorkoutBase-luokan ja toteuttaa ISavable-rajapinnan
    public class Workout : WorkoutBase, ISavable
    {
        // Lista treenin sisältämistä liikkeistä
        public List<Exercise> Exercises { get; set; }

        // Konstruktori, joka välittää päivämäärän yliluokalle
        public Workout(DateTime date) : base(date)
        {
            Exercises = new List<Exercise>();
        }

        // Lisää liikkeen treeniin
        public void AddExercise(Exercise exercise)
        {
            Exercises.Add(exercise);
        }

        // Toteuttaa abstraktin metodin ja rajapinnan metodin
        // Palauttaa treenin yhteenvedon
        public override string GetSummary()
        {
            return $"Workout {Date:dd.MM.yyyy}";
        }
    }
}