

namespace ConsoleApp.Interfaces
{
    public interface ICountryTaxCalculator
    {
        public decimal TotalIncome { get; set; }
        public decimal TotalDeduction { get; set; }
        public decimal CalculateTaxAmount();
    }
}
