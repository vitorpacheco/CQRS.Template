using CQRS.Template.Domain.SeedWork;

namespace CQRS.Template.Domain.People
{
    public interface IPersonCommandRepository : ICommandRepository<string, Person>
    {

    }
}
