using Microsoft.EntityFrameworkCore;
using SubjectManager.Api.Services;

namespace SubjectManager.Api.Configuration;

public static class DependencyInjectionConfig
{
    public static IServiceCollection AddDependencyInjectionConfig(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<DataContext>(opt => 
            opt.UseInMemoryDatabase("Database"));
        services.AddCors();

        // Add Repositories
        services.AddScoped<ISubjectRepository, SubjectRepository>();
        services.AddScoped<ILessonRepository, LessonRepository>();

        // Add Services
        services.AddScoped<ISubjectService, SubjectService>();
        services.AddScoped<ILessonService, LessonService>();

        return services;
    }
}