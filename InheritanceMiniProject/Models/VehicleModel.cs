﻿using InheritanceMiniProject.Interfaces;

namespace InheritanceMiniProject.Models;

public class VehicleModel : InventoryItemModel, IPurchasable, IRentalble
{
    public decimal DealerFee { get; set; }

    public void Purchase()
    {
        QuantityInStock -= 1;
        Console.WriteLine("This vehicle has been purchsed");
    }

    public void Rent()
    {
        QuantityInStock -= 1;
        Console.WriteLine("This vehicle has been rented");
    }

    public void ReturnRental()
    {
        QuantityInStock += 1;
        Console.WriteLine("This vehicle has been returned");
    }
}
