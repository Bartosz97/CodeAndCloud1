using System;
using System.Collections.Generic;
using System.Text;
using CodeAndCloud.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeAndCloud.Core
{
    public class DataContext : DbContext
    {
        public virtual DbSet<ContactModel> Contacts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //  optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=CodeAndCloud;Trusted_Connection=true;");
            optionsBuilder.UseSqlServer(@"Server = tcp:codeandcloud5.database.windows.net, 1433; Initial Catalog = codeandcloud; Persist Security Info = False; User ID =login; Password =CodeAndCloud123; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
