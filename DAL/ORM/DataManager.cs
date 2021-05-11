using System;
using System.Data.Entity;
using System.Linq;
using DAL.Entities;

namespace DAL.ORM
{
    public class DataManager : DbContext
    {
        public DataManager()
            : base("name=DataManager")
        {
        }
        public virtual DbSet<Category> MyEntities { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Hospital> Hospitals { get; set; }
        public virtual DbSet<Journal> Journals { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Point> Points { get; set; }
        public virtual DbSet<Producer> Producers { get; set; }
        public virtual DbSet<Vaccine> Vaccines { get; set; }

    }
}