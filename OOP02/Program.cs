using OOP02.Three_Shipment_Types;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            // a) What is the difference between a class and a struct? 

            // class => reference type , allows inheritance , can be null , stores in haep ,copy the reference
            // struct => value type , doesn't allow inheritance , can't be null,stores in stack , copy the value

            // b) Why are classes more suitable than structs for large applications? 

            // classes allow inheritance and it's more suitable for complex projects

            #endregion

            #region Q2

            // a) Which class is the parent class?
            // Shipment class

            // b) Which class is the child class? 
            // ExpressShipment

            // c) What members are inherited by ExpressShipment? 
            // public and protected members of the parent class

            // d) Why is inheritance better than duplicating the same code in multiple classes?
            // to improve our code reusability and maintainability

            #endregion

            #region Q3.1 , Q3.2
            // 1. Shipment Class
            // 2. Create Three Shipment Types 
            #endregion

            #region Q3.3

            //3.DeliveryCenter Class

            #endregion

            #region Test

            DeliveryCenter deliveryCenter = new DeliveryCenter();
            Console.Write("Enter Delivery Center Name : ");
            string centerName = Console.ReadLine();

            Console.Write("Tracking Code: ");
            string t1 = Console.ReadLine();
            Console.Write("Description: ");
            string d1 = Console.ReadLine();
            Console.Write("Weight: ");
            double w1 = double.Parse(Console.ReadLine());
            Console.Write("Delivery Fee: ");
            decimal f1 = decimal.Parse(Console.ReadLine());
            Console.Write("City: ");
            string city1 = Console.ReadLine();
            Console.Write("Street: ");
            string street1 = Console.ReadLine();
            Console.Write("Building Number: ");
            int b1 = int.Parse(Console.ReadLine());

            StandardShipment standard = new StandardShipment(
                t1, d1, w1, f1, new DeliveryAddress(city1, street1, b1));

            Console.Write("Tracking Code: ");
            string t2 = Console.ReadLine();
            Console.Write("Description: ");
            string d2 = Console.ReadLine();
            Console.Write("Weight: ");
            double w2 = double.Parse(Console.ReadLine());
            Console.Write("Delivery Fee: ");
            decimal f2 = decimal.Parse(Console.ReadLine());
            Console.Write("City: ");
            string city2 = Console.ReadLine();
            Console.Write("Street: ");
            string street2 = Console.ReadLine();
            Console.Write("Building Number: ");
            int b2 = int.Parse(Console.ReadLine());
            Console.Write("Extra Fee: ");
            decimal extraFee = decimal.Parse(Console.ReadLine());

            ExpressShipment express = new ExpressShipment(
                t2, d2, w2, f2, new DeliveryAddress(city2, street2, b2), extraFee);

            Console.Write("Tracking Code: ");
            string t3 = Console.ReadLine();
            Console.Write("Description: ");
            string d3 = Console.ReadLine();
            Console.Write("Weight: ");
            double w3 = double.Parse(Console.ReadLine());
            Console.Write("Delivery Fee: ");
            decimal f3 = decimal.Parse(Console.ReadLine());
            Console.Write("City: ");
            string city3 = Console.ReadLine();
            Console.Write("Street: ");
            string street3 = Console.ReadLine();
            Console.Write("Building Number: ");
            int b3 = int.Parse(Console.ReadLine());
            Console.Write("Destination Country: ");
            string destCountry = Console.ReadLine();
            Console.Write("Customs Fee: ");
            decimal customsFee = decimal.Parse(Console.ReadLine());

            InternationalShipment international = new InternationalShipment(
                t3, d3, w3, f3, new DeliveryAddress(city3, street3, b3), destCountry, customsFee);

            Console.WriteLine();

            if (deliveryCenter.AddShipment(standard))
                Console.WriteLine("Shipment Added Successfully.");

            if (deliveryCenter.AddShipment(express))
                Console.WriteLine("Shipment Added Successfully.");

            if (deliveryCenter.AddShipment(international))
                Console.WriteLine("Shipment Added Successfully.");

            Console.WriteLine();

            deliveryCenter.PrintAllShipments();

            Console.Write("Enter tracking code to remove: ");
            string removeCode = Console.ReadLine();
            bool removed = deliveryCenter.RemoveShipment(removeCode);
            Console.WriteLine(removed ? "Shipment removed successfully.\n" : "Shipment not found.\n");

            deliveryCenter.PrintAllShipments();
            #endregion
        }
    }
}

//            Build a Console Application that performs the following: 
//             3.Create one StandardShipment. 
//             4.Create one ExpressShipment. 
//             5.Create one InternationalShipment. 
//             6.Read all shipment data from the user. 
//             7.Add the shipments to the delivery center. 
//             8.Print all shipments. 
//             9.Search for a shipment using the existing tracking code indexer.
//             10.Remove one shipment using its tracking code.
//             11.Print the remaining shipment