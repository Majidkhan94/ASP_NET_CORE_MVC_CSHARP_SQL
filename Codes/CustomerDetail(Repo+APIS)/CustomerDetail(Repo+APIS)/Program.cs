var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

// SQL_Connection
builder.Services.AddDbContext<CustDBContext>(x => x.UseSqlServer
(builder.Configuration.GetConnectionString("Default-Connection")));

// Repository 
builder.Services.AddScoped<ICust, CCust>();

// Swagger
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

var app = builder.Build();
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}
app.UseStaticFiles();
app.UseRouting();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllerRoute(name: "default", pattern: "{controller=Customer}/{action=Index}/{id?}");
app.Run();