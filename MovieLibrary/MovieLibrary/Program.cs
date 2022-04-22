using Microsoft.EntityFrameworkCore;
using MovieLibrary.Core;
using MovieLibrary.Core.ModelsDTO;
using MovieLibrary.Core.Repositories;
using MovieLibrary.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddDbContext<MovieLibraryContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MovieLibraryDatabase")));

builder.Services.AddControllers();
builder.Services.AddMvc();

//builder.Services.AddScoped<GenericRepository, GenericRepository>();


builder.Services.AddTransient<IMovieService, MovieService>();
builder.Services.AddTransient<IMovieRepository, MovieRepository>();
builder.Services.AddTransient<IGenericRepository<MovieDto> ,GenericRepository<MovieDto>>();
//builder.Services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
