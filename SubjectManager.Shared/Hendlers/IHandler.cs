using SubjectManager.Shared.Command;

namespace SubjectManager.Shared.Hendlers;

public interface IHandler<T> where T : ICommand
{
    void Handler(T command);
}