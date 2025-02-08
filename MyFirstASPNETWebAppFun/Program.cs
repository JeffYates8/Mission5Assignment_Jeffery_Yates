var builder = WebApplication.CreateBuilder(args); // This line initializes the web application builder.

// Add services to the container.
builder.Services.AddControllersWithViews(); //Adds the MVC architecture to the application with support for both controllers and Razor views.

var app = builder.Build(); // Builds the application based on the configuration provided by the builder.

app.UseHttpsRedirection(); // Redirects all HTTP requests to HTTPS.

app.UseStaticFiles(); // Enables serving of static files like CSS, JavaScript, images, etc., from the wwwroot folder by default.

app.UseRouting(); // Enables routing in the application.

app.UseAuthorization(); // Enables authorization middleware.

app.MapControllerRoute( // Defines the default route for the application using the MVC routing pattern.
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run(); // Starts the application and begins listening for incoming HTTP requests.
