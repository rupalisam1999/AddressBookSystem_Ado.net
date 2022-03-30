using System;

namespace AddressBookSystem_Ado.net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBookSystem using Ado.net");
            AddressBookRepo addressBookRepo = new AddressBookRepo();
            addressBookRepo.checkConnection();
        }
    }
}
