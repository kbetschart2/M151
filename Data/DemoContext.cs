using Microsoft.EntityFrameworkCore;
using Data.Models;
using System;

namespace Data
{
    public class DemoContext : DbContext
    {

        public DbSet<User> TodoItem { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Privilege> Privileges { get; set; }

        public DbSet<UserToGroup> UserToGroups { get; set; }
        public DbSet<PrivilegeToGroup> PrivilegeToGroups { get; set; }

        public DemoContext(DbContextOptions<DemoContext> options)
            : base(options)
        {
        }
    }
}
