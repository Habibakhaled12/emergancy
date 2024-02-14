
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using sign.core.rebosatory;
using sign.repository.data;

namespace sign.api
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddCors();
            builder.Services.AddSwaggerGen(Options=>
            {
                Options.SwaggerDoc(name: "v1", info: new OpenApiInfo
                {
                    Title = "Emergency",
                    Description= "SignUp"

                }) ;
            
                }
            );
            builder.Services.AddDbContext<signupcontext>(options=>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("defaoultconnection"));
            });
            builder.Services.AddScoped(typeof(igenericreposatory<>), typeof(genericrebosatory<>));
              
            var app = builder.Build();

           using var scope = app.Services.CreateScope();
            var services= scope.ServiceProvider;
            var loggerfactory=services.GetRequiredService<ILoggerFactory>();
            try 
            { 
            var dbcontext= services.GetRequiredService<signupcontext>();
               await dbcontext.Database.MigrateAsync();
            
            }
            catch (Exception ex) 
            { 
            var logger=loggerfactory.CreateLogger<Program>();
                logger.LogError(ex, "an error ocure whan update database");
            }





            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseCors(c=>c.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin() );

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
         

        }
    }
}