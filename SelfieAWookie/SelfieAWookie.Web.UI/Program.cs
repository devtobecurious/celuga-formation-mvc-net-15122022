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
})
.AddRoles<IdentityRole>()
.AddEntityFrameworkStores<WebWithRightsDotnet6Context>();



builder.Services.AjouterInjectionsDependancesCustom();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
