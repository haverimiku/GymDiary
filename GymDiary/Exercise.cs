using System.Collections.Generic;

namespace GymDiary
{
    // Luokka yksittäiselle liikkeelle
    public class Exercise
    {
        // Liikkeen nimi
        public string Name { get; set; }

        // Lista sarjoista
        public List<Set> Sets { get; set; }

        // Konstruktori asettaa nimen ja luo tyhjän sarjalistan
        public Exercise(string name)
        {
            Name = name;
            Sets = new List<Set>();
        }

        // Lisää sarjan liikkeeseen
        public void AddSet(Set set)
        {
            Sets.Add(set);
        }
    }
}