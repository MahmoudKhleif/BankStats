// See https://aka.ms/new-console-template for more information
using BankStats1;

string CardNumber, BankCode, add;


BankFactory BankFactory = new BankFactory();
Info Info = new Info();
do
{
    Info.Informations();
    Console.WriteLine("Enter your Card Number : ");
    CardNumber = Console.ReadLine();
    BankCode = CardNumber.Substring(0, 6);
    IBank bank = BankFactory.GetBank(BankCode);
    Console.WriteLine(bank.Withdraw());
    Console.WriteLine("Write 'a' to try again :");
    add = Console.ReadLine();
} while (add == "a");

