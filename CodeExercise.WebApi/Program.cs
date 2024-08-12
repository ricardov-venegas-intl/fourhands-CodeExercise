 using CodeExercise.Core;

 namespace CodeExercise.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddRazorPages();  // For Razor Pages

            // Register the interface and implementation
            // builder.Services.AddScoped<IMyService, MyService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseAuthorization();

            app.MapControllers();

            app.MapRazorPages();  // Maps Razor Pages

            app.Run();
        }
    }
}
