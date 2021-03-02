using System;

namespace Task2
{
    public class Meeting
    {
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public Meeting() { }

        public Meeting(DateTime startDate, DateTime endDate)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        public TimeSpan Duration()
        {
            return this.EndDate - this.StartDate;
        }
    }
}
