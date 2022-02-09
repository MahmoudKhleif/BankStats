using BankStats1.Data;
using BankStats1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankStats1
{ //Crud Class to do Crud system (Create,read,update,delete. )
    public class Crud
    {
        public int id { get; set; }
        public string Name{ get; set; }
        public string  Bank { get; set; }
        
        //add new items
        public void Add()
        {
            
            Console.WriteLine("Write Full Name :");
            Name = Console.ReadLine();
            Console.WriteLine("Write Bank´s Name:");
            Bank = Console.ReadLine();
            var _Context = new BankContext();
            var user = new User
            {
                FullName = Name,
                Bank = Bank

            };
            _Context.Add(user);
            _Context.SaveChanges();
            Console.WriteLine("***Added successfully****\n");
        }
        // read item from dataBase

        public void GetItem()
        {
            var _Context = new BankContext();
            Console.WriteLine("ID  " + " FullName" + "                 " + "BankName\n");

            foreach (var item in _Context.Users.ToList())
            {
                Console.WriteLine(item.Id + "    " + item.FullName + item.Bank);
            }
        }


        //Update Date Function
        public void Update()
        {
            var _Context = new BankContext();
            
            Console.WriteLine("Write ID That u want to Update :");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("add your Name :");
            Name = Console.ReadLine();
            Console.WriteLine("Add your Bank :");
            Bank = Console.ReadLine();
            var user = new User
            {
                Id = id,
                FullName = Name,
                Bank = Bank,
            };
            _Context.Users.Update(user);
            _Context.SaveChanges();
            Console.WriteLine("Updated");
        }
        //delete items by Id
        public void Delete()
        {
            var _Context = new BankContext();
           
            Console.WriteLine("add your ID that u want to delete :");
            id = Convert.ToInt32(Console.ReadLine());
            var user = new User{Id = id,};
            _Context.Users.Remove(user);
            _Context.SaveChanges();
            Console.WriteLine("deleted");
        }
    }
}
