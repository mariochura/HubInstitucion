using Infrastructure.Database;
using Infrastructure.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.RegisterRepositories();
            builder.Services.RegisterBusiness();

            builder.Services.AddControllers();
            
            //builder.Services.AddDbContext<HubInstitutionContext>(options =>
              //  options.UseInMemoryDatabase("DBMemory"));
            builder.Services.AddDbContext<HubInstitutionContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
                    
            
            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
