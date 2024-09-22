using System;

namespace PatternsDisign
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {

                //Definir Información del Cliente 
                Person person= new Person("Brayan","Medina","107294149");

                Console.WriteLine("***********SUMULADOR 1***************");
                //CREDITO 1
                // Construcción de un crédito libre inversion
                ICreditBuilder creditFreeInvestment = new CreditFreeInvestmentBuilder();

                // Aquí se define el método SetPerson, ya que en el Director para la construcción por defecto no se ha definido.
                // De esta manera, es posible agregar nuevas propiedades a la clase sin necesidad de modificar el constructor.

                creditFreeInvestment.SetPerson(person);


                CreditDirector director = new CreditDirector(creditFreeInvestment);
                Credit personalCredit = director.ConstructCredit(50000, 5.5m, 5);

                Console.WriteLine(personalCredit.GetInfoPerson());
                Console.WriteLine(personalCredit);
                Console.WriteLine($"Monthly Payment: {personalCredit.CalculateMonthlyPayment():C}");


                Console.WriteLine("***********SUMULADOR 2***************");
                //CREDITO 2
                // Construcción de un crédito hipotecario
                ICreditBuilder creditMortgage = new CreditMortgageBuilder();
                director = new CreditDirector(creditMortgage);

                // Aquí se define el método SetPerson, ya que en el Director para la construcción por defecto no se ha definido.
                // De esta manera, es posible agregar nuevas propiedades a la clase sin necesidad de modificar el constructor.
                creditMortgage.SetPerson(person);

                Credit mortgageCredit = director.ConstructCredit(250000, 3.75m, 72);

                Console.WriteLine(mortgageCredit.GetInfoPerson());
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
