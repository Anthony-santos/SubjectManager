﻿using SubjectManager.Domain.Command;
using SubjectManager.Domain.Entities;
using SubjectManager.Domain.Repositories;
using SubjectManager.Domain.ValueObjects;
using SubjectManager.Shared;
using SubjectManager.Shared.Hendlers;

namespace SubjectManager.Domain.Handler;

public class CreateSemesterCommandHandler : Notifiable<Notification>, IHandler<CreateSemesterCommand>
{

    private readonly ISemesterRepository _semesterRepository;

    public CreateSemesterCommandHandler(ISemesterRepository semesterRepository) => _semesterRepository = semesterRepository;
    
    public ICommandResult Handler(CreateSemesterCommand command)
    {
        // Gerar VOs
        var period = new Period(command.Year, command.YearSection);

        // Gerar Entidades
        var semester = new Semester(period);

        AddNotifications(semester);
        if (IsValid)
            return new GeneralCommandResult(false, Notifications.Select(x => x.Message));

        _semesterRepository.PostSemester(semester);
        return new GeneralCommandResult(true, Notifications.Select(x => x.Message));
    }
}