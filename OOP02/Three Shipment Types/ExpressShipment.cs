using System;
using System.Collections.Generic;
using System.Text;

namespace OOP02.Three_Shipment_Types
{
    internal class ExpressShipment : Shipment
    {
        decimal _extraFee;
        // ExtraFee must be greater than or equal to 0. 
        public decimal ExtraFee
        {
            get { return _extraFee; }
            set
            {
                if(value>=0)
                {
                    _extraFee = value;
                }
            }
        }

        // Override the EstimatedCost property to include the extra fee.
        public override decimal EstimatedCost
        {
            get { return DeliveryFee + (decimal)(Weight * 5) + ExtraFee; }
        }

        // Create a constructor that initializes all inherited members and ExtraFee.
        public ExpressShipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination, decimal extraFee) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extraFee;
        }

        public override void PrintShipment()
        {
            Console.WriteLine("Express Shipment\n");
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description   : {Description}");
            Console.WriteLine($"Weight        : {Weight} KG");
            Console.WriteLine($"Delivery Fee  : {DeliveryFee} EGP");
            Console.WriteLine($"Extra Fee     : {ExtraFee} EGP");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }
    }
}
