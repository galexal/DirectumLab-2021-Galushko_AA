using System;

namespace Task2
{
    public class Meeting
    {
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public TimeSpan Duration => this.EndDate - this.StartDate;

 
        public Meeting(DateTime startDate, DateTime endDate)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
        }
    }
}
