using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public class TaskContext : DbContext
    {
        public TaskContext() : base("ToDoListConnection") { }

        public DbSet<Task> Tasks { get; set; }
    }
}