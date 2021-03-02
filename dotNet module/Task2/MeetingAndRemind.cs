using System;
using System.Threading;


namespace Task2
{
    public class MeetingAndRemind : Meeting, IRemind
    {
        public DateTime RemindDate { get; set; }

        public MeetingAndRemind(DateTime remindDate)
        {
            RemindDate = remindDate;
            TimerCallback tm = new TimerCallback(Remind);
            Timer timer = new Timer(tm, remindDate, 0, 2000);
        }

        public static void Remind(object obj)
        {
            DateTime remindDate = (DateTime)obj;
            if (remindDate == DateTime.Now)
            {
                Console.WriteLine("Напоминание");
            }
        }
    }
}
