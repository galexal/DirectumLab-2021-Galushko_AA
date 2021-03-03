using System;

namespace Task2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите дату начала встречи ");
            DateTime startDate;
            var startMeetingInput = Console.ReadLine();
            while (!DateTime.TryParse(startMeetingInput, out startDate))
            {
                Console.WriteLine("Введены неверные данные. Повторите ввод.");
                startMeetingInput = Console.ReadLine();
            }

            Console.WriteLine("Введите дату окончания встречи ");
            DateTime endDate;
            var endMeetingInput = Console.ReadLine();
            while (!DateTime.TryParse(endMeetingInput, out endDate))
            {
                Console.WriteLine("Введены неверные данные. Повторите ввод.");
                endMeetingInput = Console.ReadLine();
            }

            Console.WriteLine("Введите дату напоминания");
            DateTime remindDate;
            var remindMeetingInput = Console.ReadLine();
            while (!DateTime.TryParse(remindMeetingInput, out remindDate))
            {
                Console.WriteLine("Введены неверные данные. Повторите ввод.");
                remindMeetingInput = Console.ReadLine();
            }

            var meeting = new MeetingAndRemind(startDate, endDate, remindDate);

            Console.WriteLine($"Начало встречи {meeting.StartDate}");
            Console.WriteLine($"Начало встречи {meeting.EndDate}");
            Console.WriteLine($"Длительность встречи {meeting.Duration}");
            Console.WriteLine($"Напоминание установлено на {meeting.RemindDate}");
        }
    }
}
