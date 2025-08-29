namespace Ucu.Poo.Restaurant
{
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
        }

        public void Free()
        {
            this.IsOccupied = false;
            this.order.Clear();
        }

        public void AddToOrder(Dish dish)
        {
            this.order.AddToOrder(dish);
        }

        public bool HasOrders()
        {
            return this.order.Count > 0;
        }
    }
}