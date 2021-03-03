using System;
using System.Threading;


namespace Task2
{
    public class MeetingAndRemind : Meeting, IRemind
    {
        public Timer Timer;

        public DateTime RemindDate { get; set; }

        public MeetingAndRemind(DateTime startDate, DateTime endDate, DateTime remindDate) 
            : base(startDate, endDate)
        {
            RemindDate = remindDate;
            TimerCallback timerCallback = new TimerCallback(this.Remind);
            Timer = new Timer(timerCallback, remindDate, 0, 2000);
        }

        public void Remind(object obj)
        {
            DateTime remindDate = (DateTime)obj;
            if (remindDate >= DateTime.Now)
            {
                Console.WriteLine("Напоминание");
                Timer.Dispose();
            }
        }
    }
}
