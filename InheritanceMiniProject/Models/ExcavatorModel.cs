namespace InheritanceMiniProject.Models;

public class ExcavatorModel : InventoryItemModel, IRentalble
{
    public void Dig()
    {
        Console.WriteLine("I'm digging!");
    }

    public void Rent()
    {
        QuantityInStock -= 1;
        Console.WriteLine("This excavator has been rented");
    }

    public void ReturnRental()
    {
        QuantityInStock += 1;
        Console.WriteLine("This excavator has been returned");
    }
}