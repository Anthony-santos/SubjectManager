using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Context;
public class DataContext : DbContext{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<Subject> Subjects { set; get; }
    public DbSet<Lesson> Lessons { set; get; }
}