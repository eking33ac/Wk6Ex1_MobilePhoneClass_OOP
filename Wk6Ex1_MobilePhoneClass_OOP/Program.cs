using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk6Ex1_MobilePhoneClass_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Goal: Create a class to hold mobile phone information
            // Include a constructor to initialize the properties.
            // Have a method within the class to display their information.
            // Create two phones(objects of the phone class) and display their information.

            // Initialize the first phone. Set the brand to Samsung, set the model to Galaxy S25, set the storage capacity to 256 GB, and set the price to 860.3
            MobilePhone mobilePhone1 = new MobilePhone("Samsung", "Galaxy S25", "256 GB", 860.3);

            // Initialize the second phone. Set the brand to Samsung, set the model to Galaxy S25+, set the storage capacity to 512 GB, and set the price to 990.99
            MobilePhone mobilePhone2 = new MobilePhone("Samsung", "Galaxy S25+", "512 GB", 990.99);

            // Initialize the third phone. Set the brand to Samsung, set the model to Galaxy S25 Ultra, set the storage capacity to 1 TB, and set the price to 1300
            MobilePhone mobilePhone3 = new MobilePhone("Samsung", "Galaxy S25 Ultra", "1 TB", 1300);


            // display the details for phone 1
            mobilePhone1.DisplayPhoneDetails();

            // display the details for phone 2
            mobilePhone2.DisplayPhoneDetails();

            // display the details for phone 3
            mobilePhone3.DisplayPhoneDetails();

        }
    }


    // Mobile Phone Class

    class MobilePhone
    {
        // Properties/Attributes/Field Names
        public string Brand;        // Declare an attribute of the class to hold a phone's brand
        public string Model;          // Declare an attribute of the class to hold a phone's model
        public string StorageCapacity;          // Declare an attribute of the class to hold a phone's storage capacity
        public double Price;          // Declare an attribute of the class to hold a phone's price


        // Constructor
        // (Needs to have the same name as the class)
        public MobilePhone(string aBrand, string aModel, string aStorageCapacity, double aPrice)
        {
            Brand = aBrand;       // set the brand of the phone object in the mobile phone class to be the brand we type
            Model = aModel;       // set the model of the phone object in the mobile phone class to be the model we type
            StorageCapacity = aStorageCapacity;     // set the storage capacity of the phone object in the mobile phone class to be the storage capacity we type
            Price = aPrice;       // set the price of the phone object in the mobile phone class to be the price we type
        }


        // Methods

        // Method to display all student information
        public void DisplayPhoneDetails()
        {
            // print the mobile phone's details
            Console.WriteLine($"Phone Details\n" +      // title
                $"Brand: {Brand}\n" +     // output brand of the phone
                $"Model: {Model}\n" +     // output the phone's model/model number
                $"Storage Capacity: {StorageCapacity}\n" +       // output the phone's storage capacity
                $"Price: {Price:C2}\n");       // output the phone's price. End with a line break for readability
        }
    }



}
