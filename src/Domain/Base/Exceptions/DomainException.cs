using System;

namespace Domain.Base.Exceptions
{
    public class DomainException : Exception
    {
        public DomainException(string businessMessage)
            : base(businessMessage)
        {
        }
    }
}
