using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace todo_october_aspnet.core.mvc.Models
{
    public class TodoAppOctoberDBContext : DbContext
    {
        public TodoAppOctoberDBContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }


        public DbSet<Todo> Todos { get; set; }
    }
}
