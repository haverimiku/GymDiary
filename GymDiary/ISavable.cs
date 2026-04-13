namespace GymDiary
{
    // Rajapinta, joka määrittelee että luokka pystyy tuottamaan yhteenvedon
    public interface ISavable
    {
        // Metodi, joka palauttaa olion yhteenvedon merkkijonona
        string GetSummary();
    }
}