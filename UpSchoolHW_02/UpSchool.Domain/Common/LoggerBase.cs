﻿namespace UpSchool.Domain.Common
{
    public abstract class LoggerBase
    {
        public virtual void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
