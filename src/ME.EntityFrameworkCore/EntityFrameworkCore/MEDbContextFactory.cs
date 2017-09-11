using ME.Configuration;
using ME.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ME.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class MEDbContextFactory : IDesignTimeDbContextFactory<MEDbContext>
    {
        public MEDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MEDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            MEDbContextConfigurer.Configure(builder, configuration.GetConnectionString(MEConsts.ConnectionStringName));

            return new MEDbContext(builder.Options);
        }
    }
}