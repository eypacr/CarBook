using CarBook.Application.Services;
using CarBook.WebApi.Extensions;

var builder = WebApplication.CreateBuilder(args);

// DbContext'i ekleme
builder.Services.AddDbContexts(builder.Configuration);

// Diðer parçalar
builder.Services.AddRepositoryServices();
builder.Services.AddAboutCQRSHandlers();
builder.Services.AddBannerCQRSHandlers();
builder.Services.AddBrandCQRSHandlers();
builder.Services.AddCarCQRSHandlers();
builder.Services.AddCategoryCQRSHandlers();
builder.Services.AddContactCQRSHandlers();

//Mediator
builder.Services.AddApplicationService(builder.Configuration);

// Add services to the container.

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
