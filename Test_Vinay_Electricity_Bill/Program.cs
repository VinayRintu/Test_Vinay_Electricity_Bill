// See https://aka.ms/new-console-template for more information
using Test_Vinay_Electricity_Bill;

Console.WriteLine("Hello, World!");


Electrity_Service_Type_Info objElectricityType = new Electrity_Service_Type_Info();

Console.WriteLine("Enter Meter Number ");
objElectricityType.MeterNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Customer Name");
objElectricityType.CustomerName = Console.ReadLine();

Console.WriteLine("Enter Units");
objElectricityType.Units = int.Parse(Console.ReadLine());

Console.WriteLine("Your Service Type is Domestic Enter 'd' or 'D' \n" +
    "Your Service Type is Commercial Enter 'c' or 'C'");
objElectricityType.ServiceType = Console.ReadLine();

objElectricityType.ServiceTypeBill();