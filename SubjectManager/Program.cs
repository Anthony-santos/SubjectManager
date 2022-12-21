using SubjectManager.Domain.Entities;
using SubjectManager.Domain.Enums;
using SubjectManager.Domain.ValueObjects;

var period = new Period(2022, 2);
var semester = new Semester(period);
var subject =  new Subject("Matematica");
var lesson1 = new  Lesson(EDayOfWeek.Segunda, "18:00", "21:00");
var lesson2 = new  Lesson(EDayOfWeek.Quinta, "18:00", "21:00");


subject.AddLesson(lesson1);
subject.AddLesson(lesson2);

semester.AddSubject(subject);
foreach (var notification in subject.Notifications)
{
    Console.WriteLine("ERROR: " + notification.Key + " | " + notification.Message);
}

Console.WriteLine(subject.Id);
Console.WriteLine(subject.Name);
foreach (var lesson in subject.Lessons)
{
    Console.WriteLine("--------------------------");
    Console.WriteLine(lesson.Id);
    Console.WriteLine(lesson.DayOfWeek);
    Console.WriteLine("De " + lesson.StartTime + " até " + lesson.EndTime);
}