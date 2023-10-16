using Microsoft.EntityFrameworkCore;
using ProjectArtemis.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

public class Products : DbContext
{
    public DbSet<Product> ProductList { get; set; }

     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ProjectArtemis;
                                    Trusted_Connection=True;ConnectRetryCount=0");
    }
}