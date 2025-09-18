using AnotherDotnetToolkit;
using Application.HumanResourcesDomainModule;
using Microsoft.EntityFrameworkCore;
using CorujinhaAPI.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<CorujinhaDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("defaultconnection"));
});
builder.Services.AddScoped<DbContext>(provider => provider.GetService<CorujinhaDbContext>()); // Registar CorujinhaDbContext como DbContext

// Add Dependecies from HumanResources
builder.Services.RegisterHumanResourcesServices();

// Add CustomLibrary Dependecy Injection
builder.Services.AddAnotherDotnetToolkitServices();



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
