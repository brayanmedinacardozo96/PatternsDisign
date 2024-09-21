using System;

namespace PatternsDisign
{
    internal class Credit
    {
        public decimal LoanAmount { get; set; }
        public decimal InterestRate { get; set; }
        public int TermInMonths { get; set; } = 0;


        /// <summary>
        /// Ejemplo  de cálculo de pago mensual usando la fórmula de la cuota fija.
        /// </summary>
        public decimal CalculateMonthlyPayment()
        {
            
            var monthlyRate = InterestRate / 12 / 100;
            var numberOfMonths = TermInMonths;
            return (LoanAmount * monthlyRate) / (1 - (decimal)Math.Pow(1 + (double)monthlyRate, -numberOfMonths));
        }

        public override string ToString()
        {
            return $"Loan Amount: {LoanAmount:C}, Interest Rate: {InterestRate:P}, Term: {TermInMonths} years";
        }


    }
}
