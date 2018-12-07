using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oTTimoshenko.SocialNetwork.DataAccess.EntityFramework.Extensions
{
    public static class DbModelBuilderExtensions
    {
        public static void ConfigureUserRelatedTables(this DbModelBuilder modelBuilder)
        {
            ConfigureUserTable(modelBuilder);
        }

        private static void ConfigureUserTable(DbModelBuilder modelBuilder)
        {

        }

        private static void ConfigureUserProfileTable(DbModelBuilder modelBuilder)
        {

        }
    }
}
