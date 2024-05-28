using Microsoft.EntityFrameworkCore;
using test.Data;
using test.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<TestContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("MyConnection"),
    Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.20-mysql"))
);

// Servicio de los controladores
builder.Services.AddControllers();

// Servicio de los repositorios
builder.Services.AddScoped<IAuthRepository, AuthRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Mapeo de los controladores
app.MapControllers();

app.Run();

