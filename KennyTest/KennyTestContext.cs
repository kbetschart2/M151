using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KennyTest.Models;
using Microsoft.EntityFrameworkCore;

namespace KennyTest
{
    public class KennyTestContext : DbContext
    {
        public KennyTestContext(DbContextOptions<KennyTestContext> options)
            : base(options)
        {
        }

        public DbSet<TodoItem> TodoItem { get; set; }

    }
}
