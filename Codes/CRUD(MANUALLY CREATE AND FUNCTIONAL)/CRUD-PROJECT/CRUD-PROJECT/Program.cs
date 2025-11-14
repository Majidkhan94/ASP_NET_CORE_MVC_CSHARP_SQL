
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IStdDetailRepo, CStdDetailRepo>();
builder.Services.AddDbContext<StdDetailData>(x => x.UseSqlServer
(builder.Configuration.GetConnectionString("Default-Connection")));

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=StdDetail}/{action=Index}/{id?}");




app.Run();
