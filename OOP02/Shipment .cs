using System;
using System.Collections.Generic;
using System.Text;

namespace OOP02
{
  
        internal class Shipment
        {
            private string trackingCode;
            private string description;
            private double weight;
            private decimal deliveryFee;
            private DeliveryAddress destination;


            public string TrackingCode
            {
                get { return trackingCode; }
                private set // read only
                {
                    if (!string.IsNullOrWhiteSpace(value))
                    {
                        trackingCode = value;
                    }
                }
            }

            public string Description
            {
                get { return description; }
                set
                {
                    if (!string.IsNullOrWhiteSpace(value))
                    {
                        description = value;
                    }
                }

            }

            public double Weight
            {
                get { return weight; }
                set
                {
                    if (value > 0)
                    {
                        weight = value;
                    }
                }
            }

            public decimal DeliveryFee
            {
                get { return deliveryFee; }
                private set
                {
                    if (value > 0)
                    {
                        deliveryFee = value;
                    }
                }
            }

            public DeliveryAddress Destination
            {
                get { return destination; }
                set
                {
                    destination = value;
                }
            }

            public virtual decimal EstimatedCost
            {
                get { return DeliveryFee + (decimal)(Weight * 5); }
            }

            // The first constructor receives only trackingCode.
            public Shipment(string trackingCode)
            {
                TrackingCode = trackingCode;
                Description = "Unknown";
                Weight = 1;
                DeliveryFee = 50;
                Destination = new DeliveryAddress("Unknown", "Unknown", 0);
            }

            // • The second constructor receives trackingCode, description, weight, deliveryFee, and destination.
            public Shipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination)
            {
                Description = "Unknown";
                Weight = 1;
                DeliveryFee = 50;
                Destination = new DeliveryAddress("Unknown", "Unknown", 0);

                TrackingCode = trackingCode;
                Description = description;
                Weight = weight;
                DeliveryFee = deliveryFee;
                Destination = destination;
            }

            //  UpdateDeliveryFee(decimal newFee): updates the fee only when newFee is greater than 0. 
            public void UpdateDeliveryFee(decimal newFee)
            {
                if (newFee > 0)
                {
                    DeliveryFee = newFee;
                }

            }

            // • PrintShipment(): prints all shipment information, including the estimated cost. 
            public virtual void PrintShipment()
            {
                Console.WriteLine($"Tracking Code: {TrackingCode}");
                Console.WriteLine($"Description: {Description}");
                Console.WriteLine($"Weight: {Weight}");
                Console.WriteLine($"Delivery Fee: {DeliveryFee}");
                Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
                Console.WriteLine($"Estimated Cost: {EstimatedCost}");
            }
        }
    }


