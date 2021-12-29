using Microsoft.EntityFrameworkCore;
using PersonalWebsite.API;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<TodoDbContext>(opt =>
    opt.UseInMemoryDatabase("TodoList"));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new()
    {
        Title = "API Spec v1",
        Version = "v1",
        Description = "Version 1 of the API Spec"
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI( c => 
        c.SwaggerEndpoint("/swagger/index.html", "API Spec v1"));
}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();