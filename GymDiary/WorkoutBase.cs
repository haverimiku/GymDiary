using System;

namespace GymDiary
{
    public abstract class WorkoutBase
    {
        public DateTime Date { get; set; }

        public WorkoutBase(DateTime date)
        {
            Date = date;
        }

        public abstract string GetSummary();
    }
}