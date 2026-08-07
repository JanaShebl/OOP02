using System;
using System.Collections.Generic;
using System.Text;

namespace OOP02.Three_Shipment_Types
{
    internal class StandardShipment : Shipment
    {
        // Create a constructor that initializes all inherited members using constructor chaining. 
        public StandardShipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination) :base(trackingCode, description, weight, deliveryFee, destination)
        {

        }
    }
}
