using System;

namespace AddressBookSystem_Ado.net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBookSystem using Ado.net");
            AddressBookRepo addressBookRepo = new AddressBookRepo();
            AddressBookModel addressBookModel = new AddressBookModel();
            addressBookModel.FirstName = "Akash";
            addressBookModel.LastName = "Sangale";
            addressBookModel.Address = "Tawarja";
            addressBookModel.City = "latur";
            addressBookModel.State = "Maharashtra";
            addressBookModel.Zip = 413512;
            addressBookModel.PhoneNo = 8149713160;
            addressBookModel.Email = "dhiraj@gmail.com";
            addressBookModel.AddressBookName = "friend address book";
            addressBookModel.AddressBookType = "Friend";
            addressBookRepo.checkConnection();
            addressBookRepo.addNewContactToDataBase(addressBookModel);
        }
    }
}
