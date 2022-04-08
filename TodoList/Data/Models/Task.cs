using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoList.Data.Models
{
    public class Task
    {
        public Guid Id { get; set; }
        public string taskName  { get; set; }
        public string Status { get; set; }
        public DateTime date { get; set; }
        public bool Deleted { get; set; }
    }
}
