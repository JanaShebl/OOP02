using System;
using System.Collections.Generic;
using System.Text;

namespace OOP02
{
   
        internal struct DeliveryAddress
        {
            private string City;
            private string Street;
            private int BuildingNumber;

            public DeliveryAddress(string city, string street, int buildingNumber)
            {
                City = city;
                Street = street;
                BuildingNumber = buildingNumber;
            }

            public string GetFullAddress()
            {
                string fullAddress = $"Building number : {BuildingNumber}, Street : {Street}, City : {City}";
                return fullAddress;
            }
        }
    }


