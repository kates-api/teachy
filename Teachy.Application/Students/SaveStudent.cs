using MediatR;

namespace Teachy.Application;

public record SaveStudentCommand(string Name) : IRequest;

public class SaveStudentHandler : IRequestHandler<SaveStudentCommand>
{
    public Task Handle(SaveStudentCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}