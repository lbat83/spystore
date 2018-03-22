using Domain;
using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace Repository.EF
{
    public class StoreContext : DbContext
    {
        public StoreContext()
        {
        }
        public StoreContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=SpyStoreDatabase;Trusted_Connection=True;MultipleActiveResultSets=true;", 
                    options => options.ExecutionStrategy(c => new MyExecutionStrategy(c)));
            }
        }
        public DbSet<Category> Categories { get; set; }
    }
}
