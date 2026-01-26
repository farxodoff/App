using Connect_EFCore_WebAPI.Data;
using Connect_EFCore.Services;
using Connect_EFCore.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Connect_EFCore.Data;

var builder = WebApplication.CreateBuilder(args);

// Db
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(
        "Host=localhost;Port=5432;Database=ConnectEF;Username=postgres;Password=postgres")
    );

// Services

builder.Services.AddScoped<DBContext>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
//builder.Services.AddScoped<string>(_ => "DI WORKS");

// Controllers
builder.Services.AddControllers();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build(); 

app.UseSwagger();
app.UseSwaggerUI();

app.UseAuthorization();
app.MapControllers();

app.Run();