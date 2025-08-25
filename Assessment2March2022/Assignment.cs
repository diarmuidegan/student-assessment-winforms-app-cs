using System;

namespace StudentAS
{
    public class Assignment
    {
        public String Name { get; set; }
        public String Subject { get; set; }
        public DateTime Due { get; set; }
        public String Description { get; set; }
        public int PercentCompleted { get; set; }
        public bool Completed { get; set; }

        public Assignment()
        {

        }
        public Assignment(string name, string subject, DateTime due, string description, int percentCompleted, bool completed)
        {
            Name = name;
            Subject = subject;
            Due = due;
            Description = description;
            PercentCompleted = percentCompleted;
            Completed = completed;
        }
    }
}
