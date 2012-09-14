using System.Data.Entity;
using PersonalFinance.Domain.Entities;
using System.Data.Entity.Infrastructure;

namespace PersonalFinance.WebUI.Models
{
    public class WebDbContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, add the following
        // code to the Application_Start method in your Global.asax file.
        // Note: this will destroy and re-create your database with every model change.
        // 
        // System.Data.Entity.Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<PersonalFinance.WebUI.Models.WebDbContext>());

        public WebDbContext() : base("WebDbContext")
        {
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<TransactionType> TransactionTypes { get; set; }

        public DbSet<Transactions> Transactions { get; set; }

        public DbSet<Accounts> Accounts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<IncludeMetadataConvention>();

            base.OnModelCreating(modelBuilder);
        }

    }
    public class AppDbContextInitializer :
                DropCreateDatabaseIfModelChanges<WebDbContext>
    {

    }
}
