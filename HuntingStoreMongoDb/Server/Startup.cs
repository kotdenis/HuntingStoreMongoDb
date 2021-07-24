using HuntingStoreMongoDb.Server.Repositories;
using HuntingStoreMongoDb.Shared.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Text;
using System.Threading.Tasks;

namespace HuntingStoreMongoDb.Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.RegisterMongoDbRepositories();

            services.AddAuthentication(optios =>
            {
                optios.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                optios.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                optios.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                optios.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                optios.DefaultSignOutScheme = CookieAuthenticationDefaults.AuthenticationScheme;

            }).AddCookie(options =>
            {
                options.SlidingExpiration = true;
                options.ExpireTimeSpan = TimeSpan.FromHours(24);

            })
            .AddJwtBearer(options =>
            {
                options.SaveToken = true;
                //options.RequireHttpsMetadata = false;

                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Configuration["jwtSecret"])),
                    ValidateAudience = false,
                    ValidateIssuer = false
                };
                options.Events = new JwtBearerEvents
                {
                    OnTokenValidated = async context =>
                    {
                        var userRepository = context.HttpContext.RequestServices.GetRequiredService<UserRepository>();
                        var userId = context.Principal.Identity.Name;
                        var user = userRepository.GetById(userId);
                        if (user == null)
                        {
                            context.Fail("Unauthorized");
                        }
                        await Task.CompletedTask;
                    }
                };
            });

            services.AddCors();

            services.AddControllersWithViews();
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseBlazorFrameworkFiles();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseCors(x => x
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
                endpoints.MapFallbackToFile("index.html");
            });

            //CreateRegisteredUser(app);
        }

        private void CreateRegisteredUser(IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope();
            var userRepository = serviceScope.ServiceProvider.GetRequiredService<UserRepository>();

            var user = new User()
            {
                Username = "Admin"
            };

            userRepository.CreateAsync(user, password: "Secret123$");
        }
    }
}
