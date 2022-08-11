using Microsoft.EntityFrameworkCore;
using FizzBuzz.Core.Models;

namespace FizzBuzz.Core.Repositories.EntityFramework
{
    public class FBContext : DbContext
    {
        public virtual DbSet<FbModel> FbModels { get; set; }

        public FBContext() //: base("FizzBuzz.Database")
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FbModel>()
            .Property(b => b.fbString)
            .IsRequired();
        }
    }
}
