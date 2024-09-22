using System;

namespace PatternsDisign
{


    /// <summary>
    ///  Crédito de libre inversión
    /// </summary>
    internal class CreditFreeInvestmentBuilder : ICreditBuilder
    {
        private Credit _credit = new Credit();

        public Credit Build()
        {
            return _credit;
        }

        public ICreditBuilder SetPerson(Person person) {
            _credit._Person = person;
            return this;
        }

        public ICreditBuilder SetInterestRate(decimal rate)
        {
            if (rate < 1 || rate > 15)
            {
                throw new ArgumentException("La tasa de interés para un préstamo libre inversion debe estar entre 1% y 15%.");
            }

            _credit.InterestRate = rate;
            return this;
        }

        public ICreditBuilder SetLoanAmount(decimal amount)
        {
            if (amount < 1000 || amount > 100000)
            {
                throw new ArgumentException("El monto del préstamo libre inversion debe estar entre 1,000 y 100,000.");
            }

            _credit.LoanAmount = amount;
            return this;
        }

        public ICreditBuilder SetTermInMonths(int months)
        {

            if (months < 1 )
            {
                throw new ArgumentException("El plazo de un préstamo personal debe estar entre 1 y x meses.");
            }

            _credit.TermInMonths = months;
            return this;
        }
    }
}
