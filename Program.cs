var builder = WebApplication.CreateBuilder(args);

// method sets up the shared objects required by applications using the MVC Framework and the Razor view engine
builder.Services.AddControllersWithViews();
var app = builder.Build();

// use static content (js,css, images, ...)
app.UseStaticFiles();

//registers the MVC Framework as a source of endpoints using default convention for mapping requests to classes and methods
app.MapDefaultControllerRoute();

app.Run();
