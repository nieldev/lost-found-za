using LostAndFound.Data.Models;
using LostAndFound.Data.Models.Lookups;
using Microsoft.AspNet.Identity.EntityFramework;

namespace LostAndFound.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class LostAndFoundContext : IdentityDbContext<ApplicationUser>
    {
        public static LostAndFoundContext Create()
        {
            return new LostAndFoundContext();
        }

        // Your context has been configured to use a 'LostAndFoundContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'LostAndFound.Data.LostAndFoundContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'LostAndFoundContext' 
        // connection string in the application configuration file.
        public LostAndFoundContext()
            : base("name=LostAndFoundContext")
        {
        }

        public virtual DbSet<Pet> Pets { get; set; }
        //public virtual DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<LostFoundReport> LostFoundReports { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Breed> Breeds { get; set; }
        public virtual DbSet<Species> Species { get; set; }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ApplicationUser>()
                .HasOptional(x => x.Contact);
        }
    }


    // public virtual DbSet<MyEntity> MyEntities { get; set; }
}

//public class MyEntity
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//}
