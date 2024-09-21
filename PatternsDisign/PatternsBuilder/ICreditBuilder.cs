
namespace PatternsDisign
{

    /// <summary>
    ///  Esta interfaz contendrá los métodos necesarios para configurar los diferentes aspectos del crédito
    /// </summary>
    internal interface ICreditBuilder
    {
        ICreditBuilder SetLoanAmount(decimal amount);
        ICreditBuilder SetInterestRate(decimal rate);
        ICreditBuilder SetTermInMonths(int years);
        Credit Build();
    }
}
