using VibePhone.Models;
using VibePhone.Repository.Blogs;
using VibePhone.Repository.Contact;
using VibePhone.Repository.Galleries;
using VibePhone.Repository.Newsletters;
using VibePhone.Repository.Testimonials;

var builder = WebApplication.CreateBuilder(args);

// 🔹 MVC
builder.Services.AddControllersWithViews();

// 🔹 Repositories
builder.Services.AddScoped<IUserRepo, UserRepo>();
builder.Services.AddScoped<IAdminRepo, AdminRepo>();
builder.Services.AddScoped<ISliderRepo, SliderRepo>();
builder.Services.AddScoped<IFeatureRepo, FeatureRepo>();
builder.Services.AddScoped<ICategoryRepo, CategoryRepo>();
builder.Services.AddScoped<IGalleryRepo, GalleryRepo>();
builder.Services.AddScoped<IBlogRepo, BlogRepo>();
builder.Services.AddScoped<ITestimonialRepo, TestimonialRepo>();
builder.Services.AddScoped<INewslettersRepo, NewslettersRepo>();
builder.Services.AddScoped<IContactusRepo, ContactusRepo>();

// 🔹 Services
builder.Services.AddScoped<UploadImages>();
builder.Services.AddAutoMapper(typeof(Mapping));

// 🔹 Session Configuration
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30); // session expire time
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

// 🔹 Database Connection
builder.Services.AddDbContext<DBCONTEXT>(x =>
    x.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnections"))
);

// 🔹 App
var app = builder.Build();
app.UseStaticFiles();
app.UseRouting();
app.UseSession();
app.UseAuthorization();
app.MapControllers();
app.MapControllerRoute(name: "default",pattern: "{controller=Front}/{action=HomePage}/{id?}");
app.Run();
