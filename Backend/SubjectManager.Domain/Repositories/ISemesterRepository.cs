using SubjectManager.Domain.Entities;

namespace SubjectManager.Domain.Repositories;

public interface ISemesterRepository
{
    void PostSemester(Semester semester);
}