using AutoMapper;
using CQRS.Template.Domain.People;
using System;

namespace CQRS.Template.Application.Features.People.Queries.SeedWork
{
    [AutoMap(typeof(Person), ReverseMap = true)]
    public class PersonDto
    {
        public string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }
    }
}
