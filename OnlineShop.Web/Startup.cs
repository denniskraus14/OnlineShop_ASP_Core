using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OnlineShop.Data;
using OnlineShop.Data.Repositories.EmployeeRepo;
using OnlineShop.Entities.Account;
using OnlineShop.ViewModel.EmployeeViews;

namespace OnlineShop_ASP_Core {
    public class Startup {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {
            services.AddControllersWithViews();

            // Connect to the database
            //services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddDbContextPool<ApplicationContext>(
                options => options.UseSqlServer(Configuration.GetConnectionString("sqlConnection"), 
                options => options.MigrationsAssembly("OnlineShop.Data") // This allows multiple DBcontext Classes to be created.
            ));

            // Add Classes for the Scoped DI's
            InjectAppServices(services);

            // Identity Configuration: user-management actions
            services.AddIdentity<User, IdentityRole>(opt => {
                opt.Password.RequiredLength = 7;
                opt.Password.RequireDigit = false;
                opt.Password.RequireUppercase = false;

                opt.User.RequireUniqueEmail = true;
            }).AddEntityFrameworkStores<ApplicationContext>();

            // Register AutoMapper
            services.AddAutoMapper(typeof(Startup));

        }

        /// <summary>
        /// Instead of having an overly large ConfigureServices() method, we have this InjectAppServices
        /// to handle all of our Classes for Scoped Dependency Injections (DI's)
        /// </summary>
        /// <param name="services"></param>
        private void InjectAppServices(IServiceCollection services) {
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<EmployeeDisplayViewModel>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            } else {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();

            // Add authentication Middleware to ASP.NET Core's pipeline
            app.UseAuthentication();

            app.UseAuthorization();

            // Handles the URL routing
            app.UseEndpoints(endpoints => {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
