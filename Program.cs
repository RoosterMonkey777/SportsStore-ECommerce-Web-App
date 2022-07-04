using Microsoft.EntityFrameworkCore;
using SportsStore_ECommerce_Web_App.Models;

var builder = WebApplication.CreateBuilder(args);

// method sets up the shared objects required by applications using the MVC Framework and the Razor view engine
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<StoreDbContext>(opts => {
    opts.UseSqlServer(
    builder.Configuration["ConnectionStrings:SportsStoreConnection"]);
});

//The AddScoped method creates a service where each HTTP request gets its own repository object
builder.Services.AddScoped<IStoreRepository, EFStoreRepository>();

var app = builder.Build();

// use static content (js,css, images, ...)
app.UseStaticFiles();

//registers the MVC Framework as a source of endpoints using default convention for mapping requests to classes and methods
app.MapDefaultControllerRoute();

SeedData.EnsurePopulated(app);  
app.Run();
