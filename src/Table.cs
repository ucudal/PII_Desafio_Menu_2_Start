namespace Ucu.Poo.Restaurant;

/// <summary>
/// Representa una mesa en el restaurante.
/// </summary>
public class Table
{
    private Order order;

    public int Number { get; set; }
    public bool IsOccupied { get; set; }

    public Table(int number)
    {
        this.Number = number;
    }

    public void Ocupy()
    {
        this.IsOccupied = true;
        this.order = new Order();
    }

    public void Free()
    {
        this.IsOccupied = false;
        this.order  = null;
    }

    public void AddOrder(Dish dish)
    {
        this.order.AddOrder(dish);
    }

    public bool HasOrders()
    {
        if (this.order != null)
        {
            return this.order.HasOrders();
        }
        else
        {
            return false;
        }
    }
}
