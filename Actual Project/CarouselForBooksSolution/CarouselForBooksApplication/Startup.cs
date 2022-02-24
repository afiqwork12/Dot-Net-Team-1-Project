using CarouselForBooksApplication.Models;
using CarouselForBooksApplication.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarouselForBooksApplication
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddControllersWithViews(opt => opt.EnableEndpointRouting = false);
            services.AddMvc();
            services.AddScoped<IUser<string, User>, UserEFRepo>();
            services.AddScoped<IBook<int, Book, string>, BookEFRepo>();
            services.AddScoped<ICart<int, Cart, string>, CartRepo>();
            services.AddScoped<IRepo<int, BookGenre>, BookGenreRepo>();
            services.AddScoped<IRepo<int, Genre>, GenreRepo>();
            //services.AddScoped<LoginService>();
            //services.AddDbContext<CFBDBContext>(
            //    options =>
            //    {
            //        options.UseSqlServer(Configuration.GetConnectionString("afiq"));
            //    }
            //);
           
            //services.AddDbContext<CFBDBContext>(
            //    options =>
            //    {
            //        options.UseSqlServer(Configuration.GetConnectionString("phoebe"));
            //    }
            //);
            services.AddSession();
            services.AddHttpContextAccessor();
            //services.AddDbContext<CFBDBContext>(
            //    options =>
            //    {
            //        options.UseSqlServer(Configuration.GetConnectionString("lim"));
            //    }
            //);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseSession();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=User}/{action=Login}/{id?}");
            });
        }
    }
}
