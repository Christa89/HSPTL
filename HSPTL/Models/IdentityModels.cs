using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser<int, MyLogin, MyUSerRole, MyClaim>
    {
        public int EmployeeId { get; set; }
    }

    public class MyUSerRole : IdentityUserRole<int> { }
    public class MyRole : IdentityRole<int, MyUSerRole> { };
    public class MyClaim : IdentityUserClaim<int> { };
    public class MyLogin : IdentityUserLogin<int> { };

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, MyRole, int, MyLogin, MyUSerRole, MyClaim>
    {
        public ApplicationDbContext()
            : base("HospitalEntities1")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<ApplicationUser>().ToTable("User_Account");
            modelBuilder.Entity<MyUSerRole>().ToTable("AspNetUserRoles");
            modelBuilder.Entity<MyRole>().ToTable("AspNetRoles");
            modelBuilder.Entity<MyClaim>().ToTable("AspNetUserClaims");
            modelBuilder.Entity<MyLogin>().ToTable("AspNetUserLogins");


            modelBuilder.Entity<ApplicationUser>().Property(r => r.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<MyRole>().Property(r => r.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<MyClaim>().Property(r => r.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

        }
    }
}