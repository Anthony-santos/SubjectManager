namespace SubjectManager.Domain.Command;

public class CreateSemesterCommand : ICommand
{
    public int Year { get; set; }
    public int YearSection { get; set; }
}