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
    }
}
