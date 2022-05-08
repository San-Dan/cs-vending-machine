namespace vending_machine
{
    public class Product
    {
        public int Id { get; }
        public string Name { get; }
        public int Price { get; }

        public Product(int id,string name, int price)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
        }
    }
}