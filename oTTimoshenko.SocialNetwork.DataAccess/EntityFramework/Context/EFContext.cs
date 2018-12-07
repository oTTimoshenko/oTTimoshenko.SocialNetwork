using oTTimoshenko.SocialNetwork.Domain.UsersEntities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oTTimoshenko.SocialNetwork.DataAccess.EntityFramework.Context
{
    public class EFContext: DbContext
    {
        public EFContext(string connectionString): base(connectionString)
        {
            //ConfigurationManager.ConnectionStrings["MSSQLConnectionString"].ConnectionString;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
    }
}
