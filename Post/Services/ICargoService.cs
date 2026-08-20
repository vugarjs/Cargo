using Post.Enums;
using Post.Models;

namespace Post.Services;

public interface ICargoService
{
    public Customer[] customers { get; set; }
    public int CustomersCount { get; set; }
    public Courier[] couriers { get; set; }
    public int CouriersCount { get; set; }
    public CargoOrder[] orders { get; set; }
    public int OrderCount { get; set; }
    public void AddCustomer(Customer customer)
    {
        customers[CustomersCount] = customer;
        CustomersCount++;
    }
    public void AddCourier(Courier courier)
    {
        couriers[CouriersCount] = courier;
        CouriersCount++;
    }
    public void CreateOrder(CargoOrder order)
    {
        orders[OrderCount] = order;
        OrderCount++;
    }
    public void CompleteOrder(int id)
    {
        if (orders[OrderCount].Id == id)
        {
            var order = OrderStatus.Delivered;
            Console.WriteLine("Your order is Delivered.");
        }
    }
}
