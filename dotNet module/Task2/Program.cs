using System;

namespace Task2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите номер типа встречи:\n1-совещание\n2-поручение\n" +
                "3-звонок\n4-день рождения");
            TypedMeeting.MeetingType typeMeeting = TypedMeeting.MeetingType.Meeting;
            var typeMeetingInput = Console.ReadLine();
            switch (typeMeetingInput)
            {
                case "1":
                    typeMeeting = TypedMeeting.MeetingType.Meeting;
                    break;
                case "2":
                    typeMeeting = TypedMeeting.MeetingType.Order;
                    break;
                case "3":
                    typeMeeting = TypedMeeting.MeetingType.Call;
                    break;
                case "4":
                    typeMeeting = TypedMeeting.MeetingType.Birthday;
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

            var meeting = new TypedMeeting(startDate, endDate, remindDate, typeMeeting);

            Console.WriteLine(meeting);

            Console.ReadKey();
            */
        }
    }
}
