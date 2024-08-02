

using ConsoleApp.Interfaces;

namespace ConsoleApp.Classes
{
    public class TaxCalculator
    {
        decimal str;

        public decimal Calculate (ICountryTaxCalculator obj)
        {
            decimal taxAmount;
            taxAmount = obj.CalculateTaxAmount();
            
            return taxAmount;
        }
    }
}
