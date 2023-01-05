using Microsoft.EntityFrameworkCore;
using SelfieAWookie.Core.Services;
using SelfieAWookie.Web.UI.AppCode;
using SelfieAWookie.Web.UI.AppCode.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var result = builder.Configuration["NimporteQuoi"];

builder.Services.AddDbContext<DefaultDbContext>(options =>
{
    options.UseMySQL(builder.Configuration.GetConnectionString("SelfieDatabase"));
});

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
