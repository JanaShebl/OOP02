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
        }
    }
}
