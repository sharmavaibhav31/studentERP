using Microsoft.EntityFrameworkCore;
using studentERP.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<StudentDBContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("StudentDBConnection"))
);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    
}
