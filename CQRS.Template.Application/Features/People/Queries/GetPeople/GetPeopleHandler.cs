using AutoMapper;
using CQRS.Template.Application.Features.People.Queries.SeedWork;
using CQRS.Template.Domain.People;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS.Template.Application.Features.People.Queries
{
    public class GetPeopleHandler : IRequestHandler<GetPeopleQuery, IEnumerable<PersonDto>>
    {
        private readonly IMapper _mapper;

        public GetPeopleHandler(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<IEnumerable<PersonDto>> Handle(GetPeopleQuery request, CancellationToken cancellationToken)
        {
            var entities = new List<Person>()
            {
                new Person() { FirstName = "Vitor", LastName = "Pacheco", CreatedAt = DateTime.Now, LastModifiedAt = DateTime.Now },
                new Person() { FirstName = "John ", LastName = "Doe", CreatedAt = DateTime.Now, LastModifiedAt = DateTime.Now },
                new Person() { FirstName = "Jane  ", LastName = "Doe", CreatedAt = DateTime.Now, LastModifiedAt = DateTime.Now },
            };

            return _mapper.Map<IEnumerable<PersonDto>>(entities);
        }
    }
}
