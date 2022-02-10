// See https://aka.ms/new-console-template for more information
using BankStats1;
using ClassLibraryNuget;
using BankStats1.Data;
using BankStats1.Models;
using System.Linq;

string CardNumber, BankCode, add, number, number2;

BankFactory BankFactory = new BankFactory();
Crud crud = new Crud();
Info Info = new Info();
Info.Informations();
do
{
    Console.WriteLine("Enter your Card Number : ");
    CardNumber = Console.ReadLine();
    BankCode = CardNumber.Substring(0, 6);
    IBank bank = BankFactory.GetBank(BankCode);
    Console.WriteLine(bank.Withdraw());
    Console.WriteLine("Write 'A' to try again or any key to continou to Database:");
    add = Console.ReadLine();
} while (add == "A");

do {
    Info.insert();
    number = Console.ReadLine();
    switch (number)
    {
        case "1": crud.Add(); break;
        case "2": crud.GetItem(); break;
        case "3": crud.Update(); break;
        case "4": crud.Delete(); break;

    }
    Console.WriteLine("Write B to back to Crud InterFace or Any Key to exit :");
    number2 = Console.ReadLine();
} while (number2 =="B");


Console.WriteLine("Thank you so much for this wonderful time");





