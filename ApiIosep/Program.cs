using System.Text.Json.Serialization;
using System.Text.Json;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using ApiIosep.Models;
using ApiIosep.Services;
using ApiIosep.Repositorio;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddCors(options =>
//{
//    options.AddPolicy("CorsApi", builder => builder.WithOrigins(
//        "http://localhost",
//        "http://localhost:8080",
//        "http://localhost:8081",
//        "http://172.17.0.11:8080"
//    ).AllowAnyHeader().AllowAnyMethod().AllowCredentials());
//});
builder.Services.AddCors(opt =>
{
    opt.AddDefaultPolicy(builder =>
    {
        builder.SetIsOriginAllowed(origin => true) // allow any origin 
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowCredentials();
    });
});

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Key"])),
            ValidateIssuer = false,
            ValidateAudience = false

        };
    });

//builder.Services.AddDbContext<SqlDBContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("WebApiDB"),
//    options => options.CommandTimeout(600))
//    );

//builder.Services.AddScoped<IosepSaludService>();
//builder.Services.AddScoped<LoginService>();


//Inyeccion de servicios

builder.Services.ConfigureModel(builder.Configuration);
builder.Services.ConfigureService();
builder.Services.ConfigureRepository();

//PARA QUE NO HAYA BUCLES AL BUSCAR EN ENTIDADES RELACIONADAS
JsonSerializerOptions options = new()
{
    ReferenceHandler = ReferenceHandler.IgnoreCycles,
    WriteIndented = true
};
builder.Services.AddControllers()
            .AddJsonOptions(o => o.JsonSerializerOptions
                .ReferenceHandler = ReferenceHandler.IgnoreCycles
                );

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    //app.UseCors("CorsApi");
    app.UseCors();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();

public static class Config
{
    public static Dictionary<string, string> Application = new Dictionary<string, string>();
}

