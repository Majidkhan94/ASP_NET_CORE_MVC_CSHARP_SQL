using BlogWebsite.Data;
using BlogWebsite.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IAdminPanel, CAdminPanel>();
builder.Services.AddDbContext<AdminPanelData>(x => x.UseSqlServer
(builder.Configuration.GetConnectionString("Default-Connection")));
builder.Services.AddSession(option => { option.IdleTimeout = TimeSpan.FromMinutes(1); });
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

var app = builder.Build();

app.UseSession();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=AdminPanel}/{action=Index}/{id?}");




app.Run();
