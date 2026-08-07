using System;
using System.Collections.Generic;
using System.Text;

namespace OOP02.Three_Shipment_Types
{
    internal class InternationalShipment : Shipment
    {
        string _destinationCountry;
        decimal _customsFee;

        // DestinationCountry cannot be null, empty, or whitespace. 
        public string DestinationCountry
        {
            get { return _destinationCountry; }
            set { 
                if(!string.IsNullOrWhiteSpace(value))
                {
                    _destinationCountry = value;
                }
            }
        }

        // CustomsFee must be greater than or equal to 0. 
        public decimal CustomsFee {
            get { return _customsFee; }
            set
            {
                if (value >= 0)
                {
                    _customsFee = value;
                }
            }
        }
        // Override the EstimatedCost property to include the customs fee. 
        public override decimal EstimatedCost
        {
            get { return DeliveryFee + (decimal)(Weight * 5) +_customsFee; }
        }

        public InternationalShipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination, string destinationCountry, decimal customsFee) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;
        }
    }
}
