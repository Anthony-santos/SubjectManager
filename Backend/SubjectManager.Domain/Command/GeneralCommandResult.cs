using SubjectManager.Shared;

namespace SubjectManager.Domain;

public class GeneralCommandResult : ICommandResult
{
    public GeneralCommandResult(bool succeded, object messages)
    {
        Succeded = succeded;
        Messages = messages;
    }

    public bool Succeded { get; set; }
    public object Messages { get; set; } = null!;
}
