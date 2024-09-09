using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NGCPS.Data;
using Microsoft.EntityFrameworkCore;
using HandTerminalProjectBackEnd.Controllers;
using System.Globalization;
using NGCPS.Controllers; // Import CultureInfo

var builder = WebApplication.CreateBuilder(args);

// Set application-wide culture to invariant mode
var culture = CultureInfo.InvariantCulture; // Use invariant culture
CultureInfo.DefaultThreadCurrentCulture = culture;
CultureInfo.DefaultThreadCurrentUICulture = culture;

// Add services to the container.
builder.Services.AddControllers();

// Configure CORS
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

// Configure Swagger/OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add DbContext
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


// Add scoped service
builder.Services.AddScoped<WarehouseController>();
builder.Services.AddScoped<CustomerController>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Ensure CORS is applied before Authorization
app.UseCors();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
