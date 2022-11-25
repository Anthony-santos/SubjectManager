namespace SubjectManager.Test.Domain;

[TestClass]
public class SubjectTests
{
    [TestMethod]
    public void Should_Return_Error_When_Tring_To_Put_Two_Classes_In_The_Same_Time_Span()
    {
        var subject = new Subject("Programação Orientada a Objeto");
        subject.AddClass(new Class(EDayOfWeek.Segunda, new TimeOnly(18, 30), new TimeOnly(19,15)));
        
        
    }
}