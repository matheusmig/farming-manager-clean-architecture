using Domain.Base;
using Domain.Farms.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Domain.Farms.ValueObjects
{
    public class InscricaoEstadual : ValueObject
    {
        public string State { get; private set; }

        public string Number { get; private set; }

        private InscricaoEstadual()
        {
        }

        public InscricaoEstadual(string state, string number)
        {
            Regex regexIsOnlyNumber = new Regex(@"^\d$");

            //if (!regexIsOnlyNumber.Match(number).Success)
            //    throw new InscricaoEstadualInvalidCharsException(number);

            State = state;
            Number = number;
        }

        public override string ToString()
        {
            return State+" "+Number;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return State;
            yield return Number;
        }
    }
}
