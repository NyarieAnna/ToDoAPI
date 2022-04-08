using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoList.Data.ViewModels
{
    public class TaskVM
    {
        public string taskName { get; set; }
        public string Status { get; set; }
        public DateTime date { get; set; }
        public bool Deleted { get; set; }
    }
}
