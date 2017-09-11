using Abp.Zero.EntityFrameworkCore;
using ME.Authorization.Roles;
using ME.Authorization.Users;
using ME.Entities;
using ME.MultiTenancy;
using Microsoft.EntityFrameworkCore;

namespace ME.EntityFrameworkCore
{
    public class MEDbContext : AbpZeroDbContext<Tenant, Role, User, MEDbContext>
    {
        /* Define an IDbSet for each entity of the application */

        public virtual DbSet<Company> Companies { get; set; }


        public MEDbContext(DbContextOptions<MEDbContext> options)
            : base(options)
        {

        }
    }
}
