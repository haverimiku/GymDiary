using System.Collections.Generic;

namespace GymDiary
{
    // Luokka käyttäjälle, joka sisältää kaikki treenit
    public class User
    {
        // Käyttäjän nimi
        public string Name { get; set; }

        // Lista käyttäjän treeneistä
        public List<Workout> Workouts { get; set; }

        // Konstruktori luo tyhjän treenilistan
        public User(string name)
        {
            Name = name;
            Workouts = new List<Workout>();
        }

        // Lisää treeni käyttäjälle
        public void AddWorkout(Workout workout)
        {
            Workouts.Add(workout);
        }
    }
}