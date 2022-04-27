using Test.Localization;
using Volo.Abp.Application.Services;

namespace Test
{
    // test commit 3
    // test commit 4
    // test commit 5
    /* Inherit your application services from this class.
     */
    public abstract class TestAppService : ApplicationService
    {
        protected TestAppService()
        {
            LocalizationResource = typeof(TestResource);
        }
    }
}
