using System;

namespace Task2
{
    public class MeetingType : MeetingAndRemind
    {
        public Types Type { get; set; }

        public enum Types
        {
            meeting,
            order,
            call,
            birthday
        }

        public MeetingType(DateTime startDate, DateTime endDate, DateTime remindDate,
            Types type) : base(startDate, endDate, remindDate)
        {
            this.Type = type;
        }

        public string Translate()
        {
            switch (this.Type)
            {
                case Types.meeting:
                    return "совещание";
                case Types.order:
                    return "поручение";
                case Types.call:
                    return "звонок";
                case Types.birthday:
                    return "день рождения";
                default: return "что-то пошло не так";
            }
        }
    }
}
