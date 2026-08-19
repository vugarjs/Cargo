using Post.Enums;

namespace Post.Models;

public class CargoOrder
{
    public int Id { get; set; }
    public static int IdCount { get; set; }

    public Customer CustomerID { get; set; } 
    public Courier CourierID { get; set; }
    public decimal TotalPrice { get; set; }
    public DateTime CreatedAt { get; set; }

    public CargoOrder(Customer customerID, Courier courierID)
    {
        IdCount++;
        Id = IdCount;
        CustomerID = customerID;
        CourierID = courierID;
        CreatedAt = DateTime.Now;
    }
    public void UpdateStatus(Enum orderStatus)
    {
        if (orderStatus is OrderStatus.Cancelled)
        {
            return;
        }
        if(orderStatus is OrderStatus.Created)
        {
            Console.WriteLine("Order is created.");
        }
        if(orderStatus is OrderStatus.Delivered)
        {
            Console.WriteLine("Order is delivered");
        }
        if(orderStatus is OrderStatus.OnTheWay)
        {
            Console.WriteLine("Order is on the way.");
        }
        if(orderStatus is OrderStatus.Cancelled)
        {
            Console.WriteLine("Order is cancelled.");
            return;
        }
    }

}
