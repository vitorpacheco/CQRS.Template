using CQRS.Template.Api.Domain.SeedWork;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Template.Domain.People
{
    public class Person : BaseEntity
    {
        public Person()
        {
            Id = ObjectId.GenerateNewId().ToString();
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
