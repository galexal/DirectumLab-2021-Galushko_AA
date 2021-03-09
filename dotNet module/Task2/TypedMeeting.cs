using System;

namespace Task2
{
    public class TypedMeeting : MeetingAndRemind
    {
        public MeetingType Type { get; set; }

        public enum MeetingType
        {
            Meeting,
            Order,
            Call,
            Birthday
        }

        public TypedMeeting(DateTime startDate, DateTime endDate, DateTime remindDate,
            MeetingType type) : base(startDate, endDate, remindDate)
        {
            this.Type = type;
        }

        private string Translate()
        {
            switch (this.Type)
            {
                case MeetingType.Meeting:
                    return "совещание";
                case MeetingType.Order:
                    return "поручение";
                case MeetingType.Call:
                    return "звонок";
                case MeetingType.Birthday:
                    return "день рождения";
                default: return "что-то пошло не так";
            }
        }

        public override string ToString()
        {
            return $"Начало {this.StartDate}\nКонец {(this.EndDate!=default?this.EndDate:"Дата окончания встречи неизвестна")}" +
                $"\nНапоминание {this.RemindDate}\nТип {this.Translate()}";
        }
    }
}
