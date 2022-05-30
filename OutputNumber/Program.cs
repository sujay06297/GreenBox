using GreenBox.Common;
using GreenBox.Filters;
using GreenBox.Interface;
using OutputNumber.Interface;
using OutputNumber.Models;
using OutputNumber.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddLogging(d => d.AddConsole());
builder.Services.AddScoped<INumberService, NumberService>();
builder.Services.AddScoped<INumberHelper, NumberHelper>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<ActionFilter>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRequestCulture();

app.UseAuthorization();

app.MapControllers();

app.Run();
