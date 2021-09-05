using CQRS.Template.Domain.SeedWork;

namespace CQRS.Template.Domain.People
{
    public interface IPersonReadOnlyRepository : IReadOnlyRepository<string, Person>
    {

    }
}
