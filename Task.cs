using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace exam_6
{
    internal class Task
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Executor { get; set; }
        public string? Description { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime? DateCompletion { get; set; }
        public string State { get; set; }
        public Task()
        {
            State = "new";
            DateCreation = DateTime.Now;
            DateCompletion = null;
        }
    }
}
