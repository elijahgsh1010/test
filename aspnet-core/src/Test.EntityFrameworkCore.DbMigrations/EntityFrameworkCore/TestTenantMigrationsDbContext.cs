using Microsoft.EntityFrameworkCore;
using Volo.Abp.MultiTenancy;

namespace Test.EntityFrameworkCore
{
    public class TestTenantMigrationsDbContext : TestMigrationsDbContextBase<TestTenantMigrationsDbContext>
    {
        public TestTenantMigrationsDbContext(DbContextOptions<TestTenantMigrationsDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.SetMultiTenancySide(MultiTenancySides.Tenant);

            base.OnModelCreating(builder);
        }
    }
}
