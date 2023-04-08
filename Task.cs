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
        public string DateCreation { get; set; }
        public string DateCompletion { get; set; }
        public string State { get; set; }
        public Task(int id, string name, string executor, string description)
        {
            Id = id;
            Name = name;
            Executor = executor;
            Description = description;
            State = "new";
            DateCreation = DateTime.Now.ToString("d");
            DateCompletion = "don`t completed";
        }
    }
}
