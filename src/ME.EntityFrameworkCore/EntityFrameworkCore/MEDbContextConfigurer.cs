using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ME.EntityFrameworkCore
{
    public static class MEDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MEDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MEDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}