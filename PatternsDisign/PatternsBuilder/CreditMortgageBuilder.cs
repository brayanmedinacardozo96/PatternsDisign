using System;

namespace PatternsDisign
{
    /// <summary>
    ///  Crédito Hipotecario
    /// </summary>
    internal class CreditMortgageBuilder : ICreditBuilder
    {

        private Credit _credit = new Credit();

        public Credit Build()
        {
            return _credit;
        }

        public ICreditBuilder SetInterestRate(decimal rate)
        {
            if (rate < 0.5m || rate > 10)
            {
                throw new ArgumentException("La tasa de interés para un préstamo hipotecario debe estar entre 0.5% y 10%.");
            }

            _credit.InterestRate = rate;
            return this;
        }

        public ICreditBuilder SetLoanAmount(decimal amount)
        {
            if (amount < 50000 || amount > 1000000)
            {
                throw new ArgumentException("El monto del préstamo hipotecario debe estar entre 50,000 y 1,000,000.");
            }

            _credit.LoanAmount = amount;
            return this;
        }

        public ICreditBuilder SetTermInMonths(int months)
        {
            if (months < 12*5 || months > 12*30)
            {
                throw new ArgumentException("El plazo de un préstamo hipotecario debe estar entre 5 y 30 años.");
            }

            _credit.TermInMonths = months;
            return this;
        }
    }
}
