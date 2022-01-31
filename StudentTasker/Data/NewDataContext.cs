using Microsoft.EntityFrameworkCore;
using StudentTaskerModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentTasker.Data
{
    public class NewDataContext : DbContext
    {

        public NewDataContext()
        {

        }

        public NewDataContext(DbContextOptions<NewDataContext> options) : base(options)
        {

        }

        public DbSet<StudentTask> StudentTasks { get; set; }
        public DbSet<DBA> DBAs { get; set; }
    }
}
