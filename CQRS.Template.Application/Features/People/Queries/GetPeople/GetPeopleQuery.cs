using CQRS.Template.Application.Features.People.Queries.SeedWork;
using CQRS.Template.Domain.QueryMapper;
using MediatR;
using System.Collections.Generic;

namespace CQRS.Template.Application.Features.People.Queries
{
    public class GetPeopleQuery : IRequest<IEnumerable<PersonDto>>
    {
        public QueryOptions QueryOptions { get; set; }
    }
}
