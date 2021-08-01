using System.Threading.Tasks;
using Shouldly;
using Volo.Abp.Identity;
using Xunit;

namespace Test.SurerClient
{
    public class ClientAppServiceTests : TestApplicationTestBase
    {
        private readonly IIdentityUserAppService _userAppService;
        private readonly ClientAppService _clientAppService;

        public ClientAppServiceTests()
        {
            _userAppService = GetRequiredService<IIdentityUserAppService>();
        }

        [Fact]
        public async Task Initial_Data_Should_Contain_Admin_User()
        {
            //Act
            var result = await _userAppService.GetListAsync(new GetIdentityUsersInput());

            //Assert
            result.TotalCount.ShouldBeGreaterThan(0);
            result.Items.ShouldContain(u => u.UserName == "admin");
        }
    }
}