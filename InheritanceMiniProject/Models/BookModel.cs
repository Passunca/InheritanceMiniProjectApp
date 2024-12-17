﻿using InheritanceMiniProject.Interfaces;

namespace InheritanceMiniProject.Models;

public class BookModel : InventoryItemModel, IPurchasable
{
    public int NumberOfPages { get; set; }

    public void Purchase()
    {
        QuantityInStock -= 1;
        Console.WriteLine("This book has been purchsed");
    }
}
