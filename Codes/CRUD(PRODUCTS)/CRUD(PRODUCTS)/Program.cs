var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IProductRepo, CProductRepo>();
builder.Services.AddDbContext<ProductContext>(x => x.UseSqlServer
(builder.Configuration.GetConnectionString("Default-Connection")));

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Product}/{action=Index}/{id?}");




app.Run();
