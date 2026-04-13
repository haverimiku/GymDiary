using System;

namespace GymDiary
{
    // Abstrakti yliluokka treeneille
    // Sisältää yhteiset ominaisuudet, joita kaikki treenit käyttävät
    public abstract class WorkoutBase
    {
        // Treenin päivämäärä
        public DateTime Date { get; set; }

        // Konstruktori, joka asettaa päivämäärän
        public WorkoutBase(DateTime date)
        {
            Date = date;
        }

        // Abstrakti metodi -> aliluokan pakko toteuttaa tämä
        public abstract string GetSummary();
    }
}