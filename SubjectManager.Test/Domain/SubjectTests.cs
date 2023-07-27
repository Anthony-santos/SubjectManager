namespace SubjectManager.Test.Domain;

[TestClass]
public class SubjectTests
{
    private readonly Lesson _smallLesson = new(EDayOfWeek.Segunda, "18:40", "20:30");
    private readonly Lesson _bigLesson = new(EDayOfWeek.Segunda, "18:00", "21:00");

    [TestMethod]
    public void Should_Return_Error_When_Trying_To_Create_An_Subject_With_Invalid_Name()
    {
        var subject = new Subject("P");
        Assert.IsFalse(subject.IsValid);
    }

    [TestMethod]
    public void Should_Return_Error_When_Trying_To_Put_Two_Classes_In_The_Same_Time_Span()
    {
        var subject = new Subject("Meus pais morreram, e agora?");
        subject.AddLesson(_smallLesson);
        subject.AddLesson(_smallLesson);
        var totalSubjectLesson = subject.Lessons.Count();
        Assert.AreEqual(1, totalSubjectLesson);
    }

    [TestMethod]
    public void Should_Return_Error_When_Trying_To_Put_One_Class_Inside_Other()
    {
        var subject = new Subject("Batman 101");
        subject.AddLesson(_smallLesson);
        subject.AddLesson(_bigLesson);
        var totalSubjectLesson = subject.Lessons.Count();
        Assert.AreEqual(1, totalSubjectLesson);
    }
}