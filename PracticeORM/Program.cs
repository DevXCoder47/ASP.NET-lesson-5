using Microsoft.EntityFrameworkCore;
using PracticeORM.Data;
using PracticeORM.Interfaces;
using PracticeORM.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ORMContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("Local")));
builder.Services.AddScoped<IRepository, Repository>();
builder.Services.AddScoped<IDriverService, DriverService>();
builder.Services.AddAutoMapper(typeof(Program));
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
