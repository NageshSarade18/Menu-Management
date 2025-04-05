using Microsoft.EntityFrameworkCore;
using Menu.Data;

namespace Menu
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            // ✅ Explicitly set the application to listen on port 5149
            builder.WebHost.UseUrls("http://0.0.0.0:5149");

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<MenuContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString")));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Menu}/{action=Index}/{id?}");

            app.Run();
        }
    }
}

