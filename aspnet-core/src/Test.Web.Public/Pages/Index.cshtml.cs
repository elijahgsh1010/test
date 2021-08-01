using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace Test.Web.Public.Pages
{
    public class IndexModel : TestPublicPageModel
    {
        public void OnGet()
        {

        }

        public async Task OnPostLoginAsync()
        {
            await HttpContext.ChallengeAsync("oidc");
        }
    }
}
