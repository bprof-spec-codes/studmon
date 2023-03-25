using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using studmon.Models;
using studmonBackend.Data.DBContext;
using studmonBackend.Data.Repositories;
using studmonBackend.Logic;
using studmonBackend.Logic.Interfaces;
using System.Diagnostics;

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

///////////////////
builder.Services.AddTransient<ApplicationDBContext>();
///////////////////
builder.Services.AddTransient<IRepository<Terem>, TeremRepository>();
builder.Services.AddTransient<IRepository<Ora>, OraRepository>();
builder.Services.AddTransient<IRepository<Tanar>, TanarRepository>();
builder.Services.AddTransient<IRepository<Hallgato>, HallgatoRepository>();
builder.Services.AddTransient<IRepository<Teljesitmeny>, TeljesitmenyRepository>();
///////////////////
builder.Services.AddTransient<ITeremLogic, TeremLogic>();
builder.Services.AddTransient<IOraLogic, OraLogic>();
builder.Services.AddTransient<ITanarLogic, TanarLogic>();
builder.Services.AddTransient<IHallgatoLogic, HallgatoLogic>();
builder.Services.AddTransient<ITeljesitmenyLogic, TeljesitmenyLogic>();
///////////////////

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
