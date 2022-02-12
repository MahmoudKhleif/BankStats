
Icon from <a href="https://iconscout.com/icons/bank" target="_blank">Bank Icon</a> by <a href="https://iconscout.com/contributors/font-awesome" target="_blank">Font Awesome</a>
# Bank Statisc

Welcome to the banking statistics application.
This is an overview of the application.
We have a city which has five banks and these banks have a different number of Customers.
so the application creates a database for all users in order to statistic the users of these five banks.
At first, the application inquires users about the first six digits of the bank card,
and then it knows this card belonging to any bank.
After that admin can (Create-Read-Update-Delete) on Dateabase By Entity Frameworke.

## Environment

C# / EntityFrameWORK CORE 

## Design Pattren:
Factory Pattren

## Nuget Package:

Nuget Package on BankFactoryClass that return null if adimn insert wrong digits.


```C#
  public class BankFactory : IBankFactory
    {
        public IBank GetBank(string bankCode)
        {
            switch (bankCode)
            {   
                case "111111": return new BankA();
                case "222222": return new BankB();
                case "333333": return new BankC();
                case "444444": return new BankD();
                case "555555": return new BankE();

            }
            return null;
        }
    }
```
## Nuget Package link
[SwitchMK](https://www.nuget.org/packages/SwitchMK/)

