using Nursery.Core.Repositories;
using Nursery.Core.Services;
using Nursery.Data;
using Nursery.Data.Repositories;
using Nursery.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IBabyService,BabyService>();
builder.Services.AddScoped<IBabyRepository, BabyRepository>();
//builder.Services.AddSingleton<DataContext>();
builder.Services.AddDbContext<DataContext>();


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
