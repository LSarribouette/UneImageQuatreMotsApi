using Microsoft.AspNetCore.Mvc;
using UneImageQuatreMotsApi.Domain.Entities;
using UneImageQuatreMotsApi.Domain.Interfaces;
using UneImageQuatreMotsApi.Domain.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IService<Question>, QuestionRawService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.MapGet("/api/questions", ([FromServices] IService<Question> service) => service.FetchAll());
app.MapGet("/api/questions/{id}", ([FromServices] IService<Question> service, [FromRoute] int id) => service.FindBy(id));

app.Run();
