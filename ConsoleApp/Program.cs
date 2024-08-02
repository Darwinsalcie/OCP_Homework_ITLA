

using ConsoleApp.Classes;
using ConsoleApp.Interfaces;

//Intantiation of the objects
TaxCalculator oTaxCalculator = new();
ICountryTaxCalculator oTaxCalculatorForUS = new TaxCalculatorForUS();   //type name = new classtoinstanciated();
ICountryTaxCalculator oTaxCalculatorForUK = new TaxCalculatorForUK();
ICountryTaxCalculator oTaxCalculatorForIN = new TaxCalculatorForIN();

#region Setting Values

oTaxCalculatorForUS.TotalIncome = 100000; 
oTaxCalculatorForUS.TotalDeduction = 15000;  

oTaxCalculatorForUK.TotalIncome = 80000; 
oTaxCalculatorForUK.TotalDeduction = 12000; 

oTaxCalculatorForIN.TotalIncome = 6000000;  
oTaxCalculatorForIN.TotalDeduction = 500000;

#endregion


decimal UStaxAmount = oTaxCalculator.Calculate(oTaxCalculatorForUS);
decimal UKtaxAmount = oTaxCalculator.Calculate(oTaxCalculatorForUK);
decimal INtaxAmount = oTaxCalculator.Calculate(oTaxCalculatorForIN);


Console.WriteLine($"Tax Amount for US: {UStaxAmount}");
Console.WriteLine($"Tax Amount for UK: {UKtaxAmount}");
Console.WriteLine($"Tax Amount for IN: {INtaxAmount}");





