using Domain.Base.Exceptions;

namespace Domain.Farms.Exceptions
{
    public class DecimalNotPositiveException : DomainException
    {
        public DecimalNotPositiveException(decimal number)
         : base($"Given number {number} must be positive.")
        {

        }
    }
}
