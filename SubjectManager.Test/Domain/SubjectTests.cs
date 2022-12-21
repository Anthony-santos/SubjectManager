﻿namespace SubjectManager.Test.Domain;

[TestClass]
public class SubjectTests
{
    [TestMethod]
    public void Should_Return_Error_When_Trying_To_Put_Two_Classes_In_The_Same_Time_Span()
    {
        var subject = new Subject("Programação Orientada a Objeto");
        subject.AddLesson(new  Lesson(EDayOfWeek.Segunda, "18:00", "21:00"));
    }
}