using System;
using System.Collections.Generic;
using System.Text;

namespace Task7
{
    public class LoadFileException : Exception
    {
        public LoadFileException(string message, 
            Exception innerException) : base(message, innerException) { }
    }
}
