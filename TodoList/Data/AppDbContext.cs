using Microsoft.EntityFrameworkCore;
using System;

using System.Collections.Generic;
using System.Linq;
using TodoList.Data.Models;
//using System.Threading.Tasks;

namespace TodoList.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Task> Tasks { get; set; }
    }
}
