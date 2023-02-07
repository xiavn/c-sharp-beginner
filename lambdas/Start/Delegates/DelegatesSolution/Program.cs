namespace DelegatesSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            string theZone;
            ShippingFeesDelegate shippingFees;
            do {
                Console.WriteLine($"What zone are you shipping to?");
                theZone = Console.ReadLine() ?? "";
                if (theZone != "exit") {
                    ShippingInfo shippingInfo = new ShippingInfo();
                    ShippingDestination? shippingZone = shippingInfo.getShippingDestination(theZone);
                    if (shippingZone != null) {
                        Console.WriteLine($"What is the shipping price?");
                        string priceString = Console.ReadLine() ?? "0";
                        float price = float.Parse(priceString);
                        shippingFees = shippingZone.getShippingCosts;
                        Console.WriteLine($"Shipping fees are: {shippingFees(price):C2}");
                    } else {
                        Console.WriteLine("Please enter a valid destination or 'exit' to exit.");
                        
                    }
                }

            } while (theZone != "exit");
        }
    }
}
