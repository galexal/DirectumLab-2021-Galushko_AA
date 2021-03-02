using System;

namespace Task2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var meeting = new Meeting();
            Console.WriteLine("Введите дату начала встречи ");
            DateTime startDate;
            var startMeetingInput = Console.ReadLine();
            while (!DateTime.TryParse(startMeetingInput, out startDate))
            {
                Console.WriteLine("Введены неверные данные. Повторите ввод.");
                startMeetingInput = Console.ReadLine();
            }
            meeting.StartDate = startDate;

            Console.WriteLine("Введите дату окончания встречи ");
            DateTime endDate;
            var endMeetingInput = Console.ReadLine();
            while (!DateTime.TryParse(endMeetingInput, out endDate))
            {
                Console.WriteLine("Введены неверные данные. Повторите ввод.");
                endMeetingInput = Console.ReadLine();
            }
            meeting.EndDate = endDate;

            Console.WriteLine($"Начало встречи {meeting.StartDate}");
            Console.WriteLine($"Начало встречи {meeting.EndDate}");
            Console.WriteLine($"Длительность встречи {meeting.Duration()}");
        }
    }
}
