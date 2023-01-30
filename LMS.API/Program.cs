using LMS.app.Services;
using LMS.Domain.Repositories;
using LMS.infrastructure.Services;
using LMS.Persistence.EF_Core;
using LMS.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<LMSContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddScoped<IBookRepos, BookRepos>();
builder.Services.AddScoped<IStudentRepos, StudentRepos>();
builder.Services.AddScoped<IBorrowedBookRepos, BorrowedBookRepos>();

builder.Services.AddScoped<IBookServices, BookServices>();
builder.Services.AddScoped<IStudentServices, StudentServices>();
builder.Services.AddScoped<IBorrowedBookServices, BorrowedBookServices>();

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
