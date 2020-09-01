using System;
using System.Collections.Generic;
using System.Text;

namespace _58_SetExercise.Entities
{
    class LogRecord
    {
        public string Name { get; set; }
        public DateTime LogTime { get; set; }

        public LogRecord(string name, DateTime logTime)
        {
            Name = name;
            LogTime = logTime;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override bool Equals(object obj)
        { 
            if(!(obj is LogRecord))
            {
                return false;
            }

            LogRecord other = obj as LogRecord;
            return Name.Equals(other.Name);
        }

        public override string ToString()
        {
            return Name + ", " + LogTime;
        }
    }
}
