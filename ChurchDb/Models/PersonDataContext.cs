using System;
using Microsoft.EntityFrameworkCore;

namespace ChurchDb.Models
{
    public class PersonDataContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        public PersonDataContext(DbContextOptions<PersonDataContext> options)
            :base(options)
        {
            
        }
    }
}
