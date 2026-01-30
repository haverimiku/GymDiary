public class Set
{
    public double Weight { get; set; }
    public int Reps { get; set; }

    public Set(double weight, int reps)
    {
        Weight = weight;
        Reps = reps;
    }

    public override string ToString()
    {
        return $"{Weight} kg x {Reps}";
    }
}
