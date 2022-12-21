namespace SubjectManager.Domain.Command;

public class CreateSubjectCommand : ICommand
{
    public string? Name { get; set; }
}