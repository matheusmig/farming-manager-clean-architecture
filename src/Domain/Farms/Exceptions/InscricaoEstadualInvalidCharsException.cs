using Domain.Base.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Farms.Exceptions
{
    public class InscricaoEstadualInvalidCharsException : DomainException
    {
        public InscricaoEstadualInvalidCharsException(string number)
         : base($"Given IE number {number} contains invalid chars.")
        {

        }
    }
}
