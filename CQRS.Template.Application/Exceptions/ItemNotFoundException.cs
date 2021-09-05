using System;

namespace CQRS.Template.Application.Exceptions
{
    public class ItemNotFoundException : Exception
    {
        public ItemNotFoundException(string message) : base(message)
        {

        }
    }
}
