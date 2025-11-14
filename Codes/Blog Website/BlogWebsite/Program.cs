var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IUserlogin, CUserlogin>();
builder.Services.AddScoped<IPosts, CPosts>();
builder.Services.AddScoped<IComments, CComments>();

builder.Services.AddDbContext<DBCONTEXT>(x => x.UseSqlServer
(builder.Configuration.GetConnectionString("Default-Connection")));

// 🔹 Authentication & Authorization services YAHAN add karo
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/Admin/Index";   // jab login na ho to redirect karega
        options.LogoutPath = "/Admin/Logout"; // logout hone ke baad redirect
    });

builder.Services.AddAuthorization();

var app = builder.Build();

// Configure the HTTP request pipeline
app.UseStaticFiles();

app.UseRouting();

// 🔹 Order important hai: pehle Authentication, phir Authorization
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
