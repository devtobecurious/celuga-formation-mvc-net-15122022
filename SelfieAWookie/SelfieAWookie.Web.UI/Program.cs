using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SelfieAWookie.Core.Services;
using SelfieAWookie.Web.UI.AppCode;
using SelfieAWookie.Web.UI.AppCode.Models;
using WebWithRightsDotnet6.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var result = builder.Configuration["NimporteQuoi"];

builder.Services.AddDbContext<DefaultDbContext>(options =>
{
    options.UseMySQL(builder.Configuration.GetConnectionString("SelfieDatabase"));
});

builder.Services.AddDbContext<WebWithRightsDotnet6Context>(options =>
{
    options.UseMySQL(builder.Configuration.GetConnectionString("SelfieDatabase"));
});

builder.Services.AddDefaultIdentity<WebWithRightsDotnet6User>(options =>
{
    options.SignIn.RequireConfirmedEmail = true;
    options.SignIn.RequireConfirmedAccount= true;
})
.AddRoles<IdentityRole>()
.AddEntityFrameworkStores<WebWithRightsDotnet6Context>();

builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireNonAlphanumeric = true;

    options.Lockout.MaxFailedAccessAttempts = int.Parse(builder.Configuration["NbAttempts"]);
});

builder.Services.ConfigureApplicationCookie(options =>
{
    options.Cookie.HttpOnly = true;

    options.ExpireTimeSpan= TimeSpan.FromMinutes(20);

    // options.AccessDeniedPath = "/Identity/Account/AccessDenied";
});

builder.Services.AjouterInjectionsDependancesCustom();

var app = builder.Build();

// Configure the HTTP request pipeline.

// app.Environment.IsEnvironment("Machin");

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
} 
else
{
    // Singleton
    // var item = app.Services.GetService<>
    
    // Le but : Créer un role au démarrage de l'appli, sans passer par un controller donné
    var scope = app.Services.CreateScope(); //
    // RoleManager est défini dans le moteur d'injection en Scoped !
    var roleManager = scope.ServiceProvider.GetService<RoleManager<IdentityRole>>();

    var resultRole = roleManager.FindByNameAsync("Admin").Result;

    if (resultRole == null)
    {
        roleManager.CreateAsync(new IdentityRole()
        {
            Name = "Admin"
        }).Wait();
    }
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

//app.Map("", () =>
//{

//});



app.MapControllerRoute(
    name: "lesSelfies",
    pattern: "les-selfies/{id?}",
    defaults: new {controller="Selfie", action = "Index"});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
