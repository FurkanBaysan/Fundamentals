using System;

namespace EnumsDemo
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            ShippingMethod firstShippingMethod = ShippingMethod.RegularAirMail;
            ShippingMethod secondShippingMethod = ShippingMethod.RegisteredAirMail;
            ShippingMethod thirdShippingMethod = ShippingMethod.Express;

            Console.WriteLine("\t" + "Converting Shipping Method to corresponding Number ID");
            var correspondingShippingMethodNumber = (int)firstShippingMethod;
            Console.WriteLine("First Method Id: " + correspondingShippingMethodNumber); //Type-Casting

            Console.WriteLine("\t" + "Converting that Supplying Number ID to corresponding Shipping Method ");
            var methodId = 2;
            ShippingMethod receivingMethod = (ShippingMethod)methodId; //Type-Casting
            Console.WriteLine("Shipping Method: " + receivingMethod);

            Console.WriteLine("\t" + "Converting a Shipping Method to a String");
            String methodName = thirdShippingMethod.ToString();
            Console.WriteLine("Method Name: " + methodName);

            Console.WriteLine("\t" + "Converting that Supplying String to corresponding Shipping Method ");
            ShippingMethod method = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine("Shipping Method: " + method);
        }
    }
}
