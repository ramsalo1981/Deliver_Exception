namespace CAExeptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Delivery delivery = new Delivery() { Id=1, CustomerName="rami", Address="sweden", DeliveryStatus = DeliveryStatus.INTRANSIT};
            var service = new DeliveryService();
            service.Start(delivery);
            Console.WriteLine(delivery);
        }
    }
}