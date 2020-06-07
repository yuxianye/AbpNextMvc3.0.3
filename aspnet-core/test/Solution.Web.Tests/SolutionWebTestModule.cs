using System;
using System.Collections.Generic;
using System.Globalization;
using Localization.Resources.AbpUi;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Solution.Localization;
using Solution.Web;
using Solution.Web.Menus;
using Volo.Abp;
using Volo.Abp.AspNetCore.TestBase;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.UI.Navigation;
using Volo.Abp.Validation.Localization;

namespace Solution
{
    [DependsOn(
        typeof(AbpAspNetCoreTestBaseModule),
        typeof(SolutionWebModule),
        typeof(SolutionApplicationTestModule)
    )]
    public class SolutionWebTestModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.PreConfigure<IMvcBuilder>(builder =>
            {
                builder.PartManager.ApplicationParts.Add(new AssemblyPart(typeof(SolutionWebModule).Assembly));
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            ConfigureLocalizationServices(context.Services);
            ConfigureNavigationServices(context.Services);
        }

        private static void ConfigureLocalizationServices(IServiceCollection services)
        {
            var cultures = new List<CultureInfo> { new CultureInfo("en"), new CultureInfo("tr") };
            services.Configure<RequestLocalizationOptions>(options =>
            {
                options.DefaultRequestCulture = new RequestCulture("en");
                options.SupportedCultures = cultures;
                options.SupportedUICultures = cultures;
            });

            services.Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<SolutionResource>()
                    .AddBaseTypes(
                        typeof(AbpValidationResource),
                        typeof(AbpUiResource)
                    );
            });
        }

        private static void ConfigureNavigationServices(IServiceCollection services)
        {
            services.Configure<AbpNavigationOptions>(options =>
            {
                options.MenuContributors.Add(new SolutionMenuContributor());
            });
        }

        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            var app = context.GetApplicationBuilder();
            var env = context.GetEnvironment();

            app.Use(async (ctx, next) =>
            {
                try
                {
                    await next();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            });

            app.UseVirtualFiles();
            app.UseRouting();          
            app.UseAuthentication();
            app.UseAbpRequestLocalization();
            app.UseAuthorization();


            app.Use(async (ctx, next) =>
            {
                try
                {
                    await next();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            });

            app.UseConfiguredEndpoints();
        }
    }
}
