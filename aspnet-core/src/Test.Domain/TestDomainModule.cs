using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Test.Localization;
using Test.MultiTenancy;
using Volo.Abp.AuditLogging;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Commercial.SuiteTemplates;
using Volo.Abp.Emailing;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.IdentityServer;
using Volo.Abp.LanguageManagement;
using Volo.Abp.LeptonTheme.Management;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.MultiTenancy;
using Volo.Abp.PermissionManagement.Identity;
using Volo.Abp.PermissionManagement.IdentityServer;
using Volo.Abp.SettingManagement;
using Volo.Abp.TextTemplateManagement;
using Volo.Saas;
using Volo.Abp.BlobStoring.Database;
using Volo.CmsKit;
using Volo.CmsKit.Contact;
using Volo.CmsKit.Newsletters;

namespace Test
{
    [DependsOn(
        typeof(TestDomainSharedModule),
        typeof(AbpAuditLoggingDomainModule),
        typeof(AbpBackgroundJobsDomainModule),
        typeof(AbpFeatureManagementDomainModule),
        typeof(AbpIdentityProDomainModule),
        typeof(AbpPermissionManagementDomainIdentityModule),
        typeof(AbpIdentityServerDomainModule),
        typeof(AbpPermissionManagementDomainIdentityServerModule),
        typeof(AbpSettingManagementDomainModule),
        typeof(SaasDomainModule),
        typeof(TextTemplateManagementDomainModule),
        typeof(LeptonThemeManagementDomainModule),
        typeof(LanguageManagementDomainModule),
        typeof(VoloAbpCommercialSuiteTemplatesModule),
        typeof(AbpEmailingModule),
        typeof(CmsKitProDomainModule),
        typeof(BlobStoringDatabaseDomainModule)
        )]
    public class TestDomainModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpMultiTenancyOptions>(options =>
            {
                options.IsEnabled = MultiTenancyConsts.IsEnabled;
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Languages.Add(new LanguageInfo("en", "en", "English", "gb"));
                options.Languages.Add(new LanguageInfo("tr", "tr", "T??rk??e", "tr"));
                options.Languages.Add(new LanguageInfo("sl", "sl", "Sloven????ina", "si"));
                options.Languages.Add(new LanguageInfo("zh-Hans", "zh-Hans", "????????????", "cn"));
                options.Languages.Add(new LanguageInfo("de-DE", "de-DE", "Deutsche", "de"));
                options.Languages.Add(new LanguageInfo("es", "es", "Espa??ol", "es"));
            });
            Configure<NewsletterOptions>(options =>
            {
                options.AddPreference(
                    "Newsletter_Default",
                    new NewsletterPreferenceDefinition(
                        LocalizableString.Create<TestResource>("NewsletterPreference_Default"),
                        privacyPolicyConfirmation: LocalizableString.Create<TestResource>("NewsletterPrivacyAcceptMessage")
                    )
                );
            });
            

#if DEBUG
            context.Services.Replace(ServiceDescriptor.Singleton<IEmailSender, NullEmailSender>());
#endif
        }
    }
}
