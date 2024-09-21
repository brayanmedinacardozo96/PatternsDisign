namespace PatternsDisign
{
    internal class CreditDirector
    {
        private ICreditBuilder _creditBuilder;

        public CreditDirector(ICreditBuilder creditBuilder) {
            _creditBuilder = creditBuilder;
        }

        public Credit ConstructCredit(decimal amount, decimal interestRate, int termMonths)
        {
            return _creditBuilder
                .SetLoanAmount(amount)
                .SetInterestRate(interestRate)
                .SetTermInMonths(termMonths)
                .Build();
        }

    }
}
