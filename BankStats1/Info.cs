using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankStats1
{
   public class Info
    {
        public void Informations()
        {
            Console.WriteLine("Informations :\n" +
                "Welcome to the banking statistics application.\n" +
                "This is an overview of the application.\n" +
                "We have a city which has five banks and these banks" +
                " have a different number of Customers.\n" +
                "so the application creates a database for all users in order to statistic the users of these five banks.\n" +
                "At first, the application inquires users about the first six digits of the bank card,\n" +
                "and then it knows this card belonging to any bank.\n\n" +
                 "NOTE:\n\n" +
                 "If the card  start with(111111), it belongs to the BankA. \n" +
                 "If it starts with(222222), then it belongs to BankB.\n"+
                 "If it starts with(333333), then it belongs to BankC.\n"+
                 "If it starts with(444444), then it belongs to BankD.\n"+
                 "If it starts with(55555), then it belongs to BankE.\n");

        }
        public void insert()
        {
            Console.WriteLine("************************\n");
            Console.WriteLine("Welcome to Bank statistic Database\n\n"+
                "Enter 1 to Add new User:\n"+"Enter 2 To Read Database\n"+"Enter 3 to Update item:\n"+
                "Enter 4 to Delete item:\n\n");

        }
    }
}
