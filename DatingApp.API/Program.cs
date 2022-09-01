using System.Text;
using DatingApp.API.database;
using DatingApp.API.Extensions;
using DatingApp.API.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

var serverVersion = new MySqlServerVersion(new Version(8, 0, 29));
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
// builder.Services.AddDbContext<DataContext>(
//             dbContextOptions => dbContextOptions
//                 .UseMySql(connectionString, serverVersion)
//                 // The following three options help with debugging, but should
//                 // be changed or removed for production.
//                 .LogTo(Console.WriteLine, LogLevel.Information)
//                 .EnableSensitiveDataLogging()
//                 .EnableDetailedErrors()
//         );
//         builder.Services.AddScoped<ITokenService, TokenService>();


        builder.Services.AddApplicationServices(builder.Configuration);
        builder.Services.AddIdentityServices(builder.Configuration);



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
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
