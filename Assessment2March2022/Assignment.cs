using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAS
{
    class Assignment
    {
        public String Name { get; set; }
        public String Subject { get; set; }
        public DateTime Due { get; set; }
        public String Description { get; set; }
        public int PercentCompleted { get; set; }
        public bool Completed { get; set; }

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
