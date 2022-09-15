namespace SubjectManager.Infra.Context;
public class DataContext : DbContext{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<Subject> Subjects { set; get; }
    public DbSet<Lesson> Lessons { set; get; }
}