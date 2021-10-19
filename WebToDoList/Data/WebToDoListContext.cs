using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebToDoList.Models;

namespace WebToDoList.Data
{
    public class WebToDoListContext : DbContext
    {
        public WebToDoListContext (DbContextOptions<WebToDoListContext> options)
            : base(options)
        {
        }

        public DbSet<WebToDoList.Models.ToDoList> ToDoList { get; set; }
    }
}
