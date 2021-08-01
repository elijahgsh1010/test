using Microsoft.EntityFrameworkCore;

namespace Test.EntityFrameworkCore
{
    public class TestTenantMigrationsDbContextFactory :
        TestMigrationsDbContextFactoryBase<TestTenantMigrationsDbContext>
    {
        protected override TestTenantMigrationsDbContext CreateDbContext(
            DbContextOptions<TestTenantMigrationsDbContext> dbContextOptions)
        {
            return new TestTenantMigrationsDbContext(dbContextOptions);
        }
    }
}
