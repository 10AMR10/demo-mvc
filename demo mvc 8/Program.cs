namespace demo_mvc_8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();
            app.UseRouting();

            app.MapGet("/", () => "Hello World!");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello Woooorld!");
                });
                endpoints.MapGet("/amr", async context =>
                {
                    await context.Response.WriteAsync("Hello  from amr!");
                });

                endpoints.MapControllerRoute(
                    name: "Defualt",
                    pattern: "{Controller}/{action}"

                    );
                //in this step the project can't understand that this project is mvc
                //so we should go to configuer services and add this services


            });


            app.Run();
        }
    }
}
