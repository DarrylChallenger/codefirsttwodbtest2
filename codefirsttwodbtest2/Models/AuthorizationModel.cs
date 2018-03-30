namespace codefirsttwodbtest2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AuthorizationModel : DbContext
    {
        public AuthorizationModel()
            : base("name=AuthorizationModel")
        {
        }

        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<CompanyUser> CompanyUsers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
