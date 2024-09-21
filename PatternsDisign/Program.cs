using System;

namespace PatternsDisign
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                // Construcción de un crédito libre inversion
                ICreditBuilder creditFreeInvestment = new CreditFreeInvestmentBuilder();
                CreditDirector director = new CreditDirector(creditFreeInvestment);
                Credit personalCredit = director.ConstructCredit(50000, 5.5m, 5);

                Console.WriteLine(personalCredit);
                Console.WriteLine($"Monthly Payment: {personalCredit.CalculateMonthlyPayment():C}");



                // Construcción de un crédito hipotecario
                ICreditBuilder creditMortgage = new CreditMortgageBuilder();
                director = new CreditDirector(creditMortgage);
                Credit mortgageCredit = director.ConstructCredit(250000, 3.75m, 72);

                Console.WriteLine(mortgageCredit);
                Console.WriteLine($"Monthly Payment: {mortgageCredit.CalculateMonthlyPayment():C}");
            }
            catch (Exception e)
            {

                Console.WriteLine($"Message Credit: {e.Message}");
            }

         
        }
    }
}
