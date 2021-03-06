using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarouselForBooksAPI.Models;
using CarouselForBooksAPI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace CarouselForBooksAPI
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

            services.AddControllers();
            services.AddScoped<IGenerateToken<UserDTO>, GenerateToken>();
            services.AddScoped<IManageUser<string, UserDTO>, ManageUser>();
            services.AddScoped<IRepo<int, BookGenre>, BookGenreRepo>();
            services.AddScoped<IRepo<int, Genre>, GenreRepo>();
            services.AddScoped<IBook<int, Book, string>, BookRepo>();
            services.AddScoped<ICart<int, Cart, string>, CartRepo>();
            services.AddScoped<IOrder<int, Order, string>, OrderRepo>();
            services.AddScoped<IOrderItem<int, OrderItem, int>, OrderItemRepo>();
            //services.AddScoped<LoginService>();
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(otps =>
            {
                otps.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = false,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["TokenKey"])),
                    ValidateIssuerSigningKey = true,
                    ValidateAudience = false
                };
            });
            services.AddDbContext<CFBDBContext>(
                options =>
                {
                    options.UseSqlServer(Configuration.GetConnectionString("afiq"));
                }
            );
            //services.AddDbContext<CFBDBContext>(
            //    options =>
            //    {
            //        options.UseSqlServer(Configuration.GetConnectionString("phoebe"));
            //    }
            //);
            //services.AddDbContext<CFBDBContext>(
            //    options =>
            //    {
            //        options.UseSqlServer(Configuration.GetConnectionString("lim"));
            //    }
            //);
            services.AddSwaggerGen();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI();

            }

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
