using AutoMapper;
using Test.Users;
using Volo.Abp.AutoMapper;

namespace Test
{
    // commit 8
    public class TestApplicationAutoMapperProfile : Profile
    {
        public TestApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            CreateMap<AppUser, AppUserDto>().Ignore(x => x.ExtraProperties);
        }
    }
}