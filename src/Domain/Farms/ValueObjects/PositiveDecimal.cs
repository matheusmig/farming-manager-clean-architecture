using Domain.Base;
using Domain.Farms.Exceptions;
using System.Collections.Generic;

namespace Domain.Farms.ValueObjects
{
    public class PositiveDecimal : ValueObject
    {
        public decimal Value { get; private set; } 

        private PositiveDecimal()
        {
        }

        public PositiveDecimal(decimal value)
        {
            if (value < 0)
                throw new DecimalNotPositiveException(value);

            Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Value;
        }
    }
}
