using System;

namespace Amccloy.TimerUtils
{
    public class TimerException : Exception
    {
        public TimerException()
        {
        }

        public TimerException(string message)
            : base(message)
        {
        }

        public TimerException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}