using System.Text;
using DotNetEnv;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using PruebaNET_SantiagoPineda.Config;
using PruebaNET_SantiagoPineda.Data;
using PruebaNET_SantiagoPineda.Repositories;
using PruebaNET_SantiagoPineda.Services;

var builder = WebApplication.CreateBuilder(args);

//Database conection
Env.Load();
var db_host = Environment.GetEnvironmentVariable("DB_HOST");
var db_port = Environment.GetEnvironmentVariable("DB_PORT");
var db_database = Environment.GetEnvironmentVariable("DB_DATABASE");
var db_username = Environment.GetEnvironmentVariable("DB_USERNAME");
var db_password = Environment.GetEnvironmentVariable("DB_PASSWORD");
var conectionDb = $"server={db_host};port={db_port};database={db_database};uid={db_username};password={db_password}";

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseMySql(conectionDb, ServerVersion.Parse("8.0.20-mysql")));

builder.Services.AddSingleton<Utilities>(); //add singleton to use the utilities

builder.Services.AddScoped<IRoomTypeRepository, RoomTypeService>(); 
builder.Services.AddScoped<IRoomRepository, RoomService>();
builder.Services.AddScoped<IGuestRepository, GuestService>(); 

builder.Services.AddScoped<IEmployeeRepository, EmployeeService>(); 



//JWT configuration
builder.Services.AddAuthentication(config =>
{
    config.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    config.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    config.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(config =>
{
    config.RequireHttpsMetadata = false;
    config.SaveToken = true;
    config.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidIssuer = Environment.GetEnvironmentVariable("JWT_ISSUER"),
        ValidateAudience = false, // false because the audience is public
        ValidAudience = Environment.GetEnvironmentVariable("JWT_AUDIENCE"),
        ValidateLifetime = true,
        ClockSkew = TimeSpan.Zero,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Environment.GetEnvironmentVariable("JWT_KEY")!))
    };
});



// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Hotel", Version = "v1" });

    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "JWT Authorization header using the Bearer scheme. Example: \"Bearer {token}\"",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.Http,
        Scheme = "Bearer"
    });
    c.EnableAnnotations();

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] {}
        }
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

// welcome page implementation

app.Use(async (context, next) =>
{
    if (context.Request.Path == "/")
    {
        var htmlContent = @"
        <html>
            <head>
                <title>Prueba de .Net de Santiago Pineda</title>
            </head>
            <body style='font-family: Arial, sans-serif; background-color: #f4f4f4; text-align: center; height: 90%; display: flex; flex-direction: column; justify-content: center; align-items: center;'>
                <h1 style='color: #333; font-size: 36px;'>Welcome to Santiago test API</h1>
                <a href='/swagger' style='color: #007bff; text-decoration: none;'> Click here to Swagger documentation</a>
            </body>
        </html>";

        context.Response.ContentType = "text/html";
        await context.Response.WriteAsync(htmlContent);
    }
    else
    {
        await next();
    }
});

app.MapControllers();

app.Run();
