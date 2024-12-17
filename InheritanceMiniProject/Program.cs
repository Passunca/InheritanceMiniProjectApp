using InheritanceMiniProject.Interfaces;
using InheritanceMiniProject.Models;

class Program
{
    private static void Main(string[] args)
    {
        List<IRentalble> rentables = new List<IRentalble>();
        List<IPurchasable> purchasables = new List<IPurchasable>();

        var vehicle = new VehicleModel { DealerFee = 25, ProductName = "Kia Optima" };
        var book = new BookModel { ProductName = "A Tale of Two Cities", NumberOfPages = 350 };
        var excavator = new ExcavatorModel { ProductName = " Bulldozer", QuantityInStock = 2 };

        rentables.Add(vehicle);
        rentables.Add(excavator);

        purchasables.Add(book);
        purchasables.Add(vehicle);

        Console.WriteLine("Do you want to rent or purchase something: (rent, purchase)");

        string decision = Console.ReadLine();

        if (decision.ToLower() == "rent")
        {
            foreach (var item in rentables)
            {
                Console.WriteLine($"Item: {item.ProductName}");
                Console.Write("Do you want to rent this item? (yes/no)");
                string rentDecision = Console.ReadLine();

                if (rentDecision.ToLower() == "yes")
                {
                    item.Rent();
                }

                Console.Write("Do you want to return this item? (yes/no)");
                string returnDecision = Console.ReadLine();

                if (returnDecision.ToLower() == "yes")
                {
                    item.ReturnRental();
                }
            }

        }
        else
        {
            foreach (var item in purchasables)
            {
                Console.WriteLine($"Item: {item.ProductName}");
                Console.Write("Do you want to purchase this item? (yes/no)");
                string purchaseDecision = Console.ReadLine();

                if (purchaseDecision.ToLower() == "yes")
                {
                    item.Purchase();
                }
            }
        }

        Console.WriteLine("We are done");

        Console.ReadLine();
    }
}