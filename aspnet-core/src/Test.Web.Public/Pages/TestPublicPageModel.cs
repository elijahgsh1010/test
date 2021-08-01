using Test.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Test.Web.Public.Pages
{
    /* Inherit your Page Model classes from this class.
     */
    public abstract class TestPublicPageModel : AbpPageModel
    {
        protected TestPublicPageModel()
        {
            LocalizationResourceType = typeof(TestResource);
        }
    }
}
