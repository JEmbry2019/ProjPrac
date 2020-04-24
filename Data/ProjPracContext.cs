using ProjPrac.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjPrac.Data
{
    //Creates a new database context named ProjPracContext
    public class ProjPracContext : DbContext
    {
        public ProjPracContext(DbContextOptions<ProjPracContext> options) : base(options)
        {
        }

        //This is where we register our models as entities
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Camper> Campers { get; set; }
        public DbSet<Game> Games { get; set; }
    }
}