using HomeCinema.Data.Configurations;
using HomeCinema.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCinema.Data
{
    public class HomeCinemaContext : DbContext
    {
        public HomeCinemaContext() : base("HomeCinema")
        {
            Database.SetInitializer<HomeCinemaContext>(null);
        }
        #region Entity Sets 
        public IDbSet<User> Users { get; set; }
        public IDbSet<Role> Roles { get; set; }
        public IDbSet<UserRole> UserRoles { get; set; }
        public IDbSet<Customer> Customers { get; set; }
        public IDbSet<Movie> Movies { get; set; }
        public IDbSet<Genre> Genres { get; set; }
        public IDbSet<Stock> Stocks { get; set; }
        public IDbSet<Rental> Rentals { get; set; }
        public IDbSet<Error> Errors { get; set; }
        #endregion
        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Configurations.Add(new UserConfiguration());
            //modelBuilder.Configurations.Add(new UserRoleConfiguration());
            //modelBuilder.Configurations.Add(new RoleConfiguration());
            //modelBuilder.Configurations.Add(new CustomerConfiguration());
            //modelBuilder.Configurations.Add(new MovieConfiguration());
            //modelBuilder.Configurations.Add(new GenreConfiguration());
            //modelBuilder.Configurations.Add(new StockConfiguration());
            //modelBuilder.Configurations.Add(new RentalConfiguration());
        }
    }
}
