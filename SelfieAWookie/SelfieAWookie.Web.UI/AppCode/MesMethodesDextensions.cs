using SelfieAWookie.Core.Services;

namespace SelfieAWookie.Web.UI.AppCode
{
	public static class MesMethodesDextensions
	{
		public static IServiceCollection AjouterInjectionsDependancesCustom(this IServiceCollection services)
		{
		
			// builder.Services.AddScoped<IWookieeService, WookieeMySQLService>();
			services.AddSingleton<ILoggerCustom, LocalLoggerCustom>(); // Unique par application
			services.AddScoped<IWookieeService, WookieeLocalFileService>(); // Par requête

			return services;
		}
	}
}
