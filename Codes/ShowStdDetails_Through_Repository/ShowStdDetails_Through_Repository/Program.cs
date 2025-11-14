var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IStdDetailsRepo, StdDetailsRepo>();
builder.Services.AddSingleton<StdDetailsModelData>();
var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=StdDetails}/{action=ShowStdInfo}/{id?}");




app.Run();
