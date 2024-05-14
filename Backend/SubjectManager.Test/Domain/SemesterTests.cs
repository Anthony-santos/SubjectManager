using SubjectManager.Domain.ValueObjects;

namespace SubjectManager.Test.Domain;

[TestClass]
public class SemesterTest
{
    private readonly Period _validPeriod = new Period("2024.1");
    
    [TestMethod]
    public void Create_Semester_With_Valid_String()
    {
        var semester = new Semester("2024.1");
        Assert.IsTrue(semester.IsValid);
    }

    [TestMethod]
    public void Create_Semester_With_Valid_Period_Object()
    {
        var semester = new Semester(_validPeriod);
        Assert.IsTrue(semester.IsValid);
    }
}