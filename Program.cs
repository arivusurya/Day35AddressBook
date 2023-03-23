
using System;

namespace LINQAddressBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LINQ AddressBookSystem!");
            //Create Object for DataTable
            ContactDataManager contactDataManager = new ContactDataManager();
            ContactDataManager contactDataManagers = new ContactDataManager();
            DataTableManager dataTableManger = new DataTableManager();
            dataTableManger.CreateDataTable();

            //Insert Values into Table
            contactDataManager.FirstName = "Shalini";
            contactDataManager.LastName = "Venkatesh";
            contactDataManager.PhoneNumber = 9842905050;
            contactDataManager.Email = "shalini@gmail.com";
            contactDataManager.Address = "4,B Block,Avadi";
            contactDataManager.City = "chennai";
            contactDataManager.State = "TN";
            contactDataManager.zip = 600072;
            dataTableManger.InsertintoDataTable(contactDataManager);

            //Modify
            int varl = dataTableManger.EditDataTable("lalita", "Lastname");
            Console.WriteLine("Success" + varl);
            //Delete
            int var2 = dataTableManger.DeleteRowInDataTable("lalita");
            Console.WriteLine("Success" + varl);
            //Retrieve based on city or state
            string var3 = dataTableManger.RetrieveBasedOnCityorState("Bareilly", "UP");
            Console.WriteLine("Success" + varl);
            //count based on city or state
            string var4 = dataTableManger.RetrieveCountBasedOnCityorState();
            Console.WriteLine("Success" + varl);
            //sort based on name in data table
            string var5 = dataTableManger.SortBasedOnNameInDataTable("chennai");
            Console.WriteLine("Success" + varl);
        }
    }
}