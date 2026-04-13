namespace GymDiary
{
    // Luokka yksittäiselle sarjalle
    public class Set
    {
        // Käytetty paino
        public double Weight { get; set; }

        // Toistojen määrä
        public int Reps { get; set; }

        // Konstruktori asettaa arvot
        public Set(double weight, int reps)
        {
            Weight = weight;
            Reps = reps;
        }
    }
}