using System;

namespace Task2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите номер типа встречи:\n1-совещание\n2-поручение\n" +
                "3-звонок\n4-день рождения");
            MeetingType.Types typeMeeting = MeetingType.Types.meeting;
            var typeMeetingInput = Console.ReadLine();
            switch (typeMeetingInput)
            {
                case "1":
                    typeMeeting = MeetingType.Types.meeting;
                    break;
                case "2":
                    typeMeeting = MeetingType.Types.order;
                    break;
                case "3":
                    typeMeeting = MeetingType.Types.call;
                    break;
                case "4":
                    typeMeeting = MeetingType.Types.birthday;
                    break;
            }

            Console.WriteLine("Введите дату начала встречи ");
            DateTime startDate;
            var startMeetingInput = Console.ReadLine();
            while (!DateTime.TryParse(startMeetingInput, out startDate))
            {
                Console.WriteLine("Введены неверные данные. Повторите ввод.");
                startMeetingInput = Console.ReadLine();
            }

            Console.WriteLine("Введите дату окончания встречи или \"нет\", " +
                "если она неизвестна");
            DateTime endDate;
            var endMeetingInput = Console.ReadLine();
            while (endMeetingInput != "нет" & !DateTime.TryParse(endMeetingInput, out endDate))
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

            var meeting = new MeetingType(startDate, endDate, remindDate, typeMeeting);

            Console.WriteLine($"Тип встречи {meeting.Translate()}");
            Console.WriteLine($"Начало встречи {meeting.StartDate}");
            if (meeting.EndDate != default)
                Console.WriteLine($"Конец встречи {meeting.EndDate}");
            else Console.WriteLine("Дата окончания встречи неизвестна");
            if (meeting.EndDate != default)
                Console.WriteLine($"Длительность встречи {meeting.Duration}");
            else Console.WriteLine("Длительность встречи неизвестна");
            Console.WriteLine($"Напоминание установлено на {meeting.RemindDate}");

            Console.ReadKey();
        }
    }
}
