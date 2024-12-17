using InheritanceMiniProject.Interfaces;

namespace InheritanceMiniProject.Models;

public interface IRentalble : IInventoryItem
{
    void Rent();
    void ReturnRental();
}
