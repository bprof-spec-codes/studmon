using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using studmon.Models;
using studmonBackend.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<ApplicationDBContext>(option =>
{
    option
    .UseSqlServer("Server=(localdb)\\\\mssqllocaldb;Database=StudmonJWT;Trusted_Connection=True;MultipleActiveResultSets=true")
    .UseLazyLoadingProxies();
});

builder.Services.AddIdentity<Tanar, IdentityRole>(option =>
{
    option.Password.RequiredLength = 8;
    option.Password.RequireNonAlphanumeric = false;
})
.AddEntityFrameworkStores<ApplicationDBContext>()
.AddDefaultTokenProviders();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
