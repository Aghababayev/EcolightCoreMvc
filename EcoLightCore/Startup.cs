using BusinessLAyer.Abstract;
using BusinessLAyer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFrmaework;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcoLightCore
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
            //Fluent validation used in BusinessLayer_______________________________________________________
            services.AddControllersWithViews().AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<Startup>());
            //Authorization_____________________________________________________________
            services.AddMvc();  
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                   .AddCookie(x =>
                   {
                       x.LoginPath = "/Login/Index";
                   });

            services.AddMvc(config =>
            {
                var policy = new AuthorizationPolicyBuilder()
                  .RequireAuthenticatedUser()
                  .Build();
                config.Filters.Add(new AuthorizeFilter(policy));

            }
            );
            //__________________________________________________________________________-

            //Dependency Injection__________________________________________________________
            //---------------------------------------------------------------DATA ACCESS>>>>>BUSINESS
            services.AddScoped<IBrandDAL, EFBrand>();
            services.AddScoped<IProductDAL, EFProduct>();
            services.AddScoped<IDistributorDAL, EFDistributor>();
            services.AddScoped<IOrderDAL, EFOrder>();
            //-------------------------------------------------------------------BUSINESS>>>>>>PRESENTATION
            services.AddScoped<IBrandService, BrandManager>();
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IDistributorService, DistributorManager>();
            services.AddScoped<IOrderService, OrderManager>();



            //________________________________________________________________________________

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseStaticFiles();
            app.UseHttpsRedirection();
           
            app.UseAuthentication();    
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

            });
        }
    }
}
