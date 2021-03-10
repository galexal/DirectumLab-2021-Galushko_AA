namespace Task5
{
    public class StringValue
    {
        public string Value { get; private set; }

        public StringValue(string value)
        {
            this.Value = value;
        }

        public override bool Equals(object obj)
        {
            if (obj is StringValue value) 
                return this.Value.Equals(value.Value);
            return false;
        }

        public override int GetHashCode()
        {
            return this.Value.GetHashCode();
        }

        public static bool operator ==(StringValue sv1, StringValue sv2)
        {
            return sv1.Value == sv2.Value;
        }

        public static bool operator !=(StringValue sv1, StringValue sv2)
        {
            return sv1.Value != sv2.Value;
        }
    }
}
