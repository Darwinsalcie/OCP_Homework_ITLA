﻿using ConsoleApp.Interfaces;

namespace ConsoleApp.Classes
{
    public class TaxCalculatorForUK : ICountryTaxCalculator
    {
        public decimal TotalIncome { get; set; }
        public decimal TotalDeduction { get; set; }

        public decimal CalculateTaxAmount()
        {
            decimal taxableIncome = TotalIncome - TotalDeduction;
            return taxableIncome * 35 / 100;
        }
    }
}
