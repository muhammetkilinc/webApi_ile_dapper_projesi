using Microsoft.Extensions.DependencyInjection;
using System.Data;
using System.Data.SqlClient;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Proje IDbConnection kullanarak projeLocal veri tabanýna uygulama ilk çalýþtýðýnda gerekli baðlantýlarý saðlanýr.
builder.Services.AddScoped<IDbConnection>(_ => new SqlConnection(
    builder.Configuration.GetConnectionString("ProjeLocal")));

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
