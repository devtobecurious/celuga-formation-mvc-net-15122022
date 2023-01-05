using SelfieAWookie.Core.Services.Selfies;
using SelfieAWookie.Core.Services.Wookies;

namespace SelfieAWookie.Web.UI.AppCode
{
    public static class MesMethodesDextensions
    {
        public static IServiceCollection AjouterInjectionsDependancesCustom(this IServiceCollection services)
        {
            services.InjectionPourSelfies();
            services.InjectionPourWookies();

            return services;
        }

        public static IServiceCollection InjectionPourSelfies(this IServiceCollection services)
        {
            services.AddScoped<ISelfieService, SelfieMySqlService>();

            return services;
        }

        public static IServiceCollection InjectionPourWookies(this IServiceCollection services)
        {
            // builder.Services.AddScoped<IWookieeService, WookieeMySQLService>();
            services.AddSingleton<ILoggerCustom, LocalLoggerCustom>(); // Unique par application
            services.AddScoped<IWookieeService, WookieeLocalFileService>(); // Par requête

            return services;
        }
    }
}
