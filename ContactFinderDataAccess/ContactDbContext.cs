using ContactFinderEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactFinderDataAccess
{
    public class ContactDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=Ruslanovic; Database=TelContactsDb; Trusted_Connection=True");
        }
        public DbSet<Contact> Contacts { get; set; }
    }
}
