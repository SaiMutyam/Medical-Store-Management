using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupServer.Model
{
    public class DbConnect : DbContext
    {
        public DbConnect(DbContextOptions<DbConnect> options) : base(options)
        {

        }
        public DbSet<Medicine> Medicines { get; set; }
       // public DbSet<User> users { get; set; }
        public DbSet<Admin> admins { get; set; }
        public DbSet<userl> userls { get; set; }
    }
}
