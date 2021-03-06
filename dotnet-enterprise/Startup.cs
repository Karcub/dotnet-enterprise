using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using dotnet_enterprise.Models;
using dotnet_enterprise.Interfaces;

namespace dotnet_enterprise
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
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                    builder =>
                    {
                        builder.WithOrigins("http://localhost:3000")
                        .AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin();
                    });
            });

            services.AddControllers();

            if (bool.Parse(Configuration["UseSQLDatabase"]))
            {
                services.AddDbContextPool<EventContext>(
                           options => options.UseSqlServer(Configuration.GetConnectionString("EventItemDBConnection")));
                services.AddTransient<IEventItemRepository, EventItemRepository>();

            }
            else
            {
                services.AddDbContext<EventContext>(opt =>
                                                   opt.UseInMemoryDatabase("EventList"));
                services.AddScoped<IEventItemRepository, EventItemRepository>();
            }

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (!bool.Parse(Configuration["UseSQLDatabase"]))
            {
                var scope = app.ApplicationServices.CreateScope();
                var context = scope.ServiceProvider.GetRequiredService<EventContext>();
                AddStartupData(context);
            }

                if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        private static void AddStartupData(EventContext context)
        {
            new EventInitializer().EventItems.ToList().ForEach(item => context.Add(item));
            context.SaveChanges();
        }
    }
}