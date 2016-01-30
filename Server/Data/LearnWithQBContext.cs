using System;
using System.Data.Entity;
using System.Linq;
using LearnWithQB.Server.Data.Contracts;
using LearnWithQB.Server.Models;

namespace LearnWithQB.Server.Data
{
    public class LearnWithQBContext : Common.Data.BaseDbContext, ILearnWithQBContext
    {
        public LearnWithQBContext()
            : base("LearnWithQBContext") { }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Customer> Customers { get; set; }
        
        public override int SaveChanges()
        {
            foreach (var entry in this.ChangeTracker.Entries()
            .Where(e => e.Entity is ILoggable &&
                ((e.State == EntityState.Added || (e.State == EntityState.Modified)))))
            {

                if (((ILoggable)entry.Entity).CreatedDate == null)
                {
                    ((ILoggable)entry.Entity).CreatedDate = DateTime.UtcNow;
                }

                ((ILoggable)entry.Entity).LastModifiedDate = DateTime.UtcNow;

            }

            return base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().

                HasMany(u => u.Roles).
                WithMany(r => r.Users).

                Map(
                    m =>
                    {
                        m.MapLeftKey("User_Id");
                        m.MapRightKey("Role_Id");
                        m.ToTable("UserRoles");
                    });

            modelBuilder.Entity<User>().

                HasMany(u => u.Groups).
                WithMany(g => g.Users).

                Map(
                    m =>
                    {
                        m.MapLeftKey("User_Id");
                        m.MapRightKey("Group_Id");
                        m.ToTable("UserGroups");
                    });

        }        
    }    
}
