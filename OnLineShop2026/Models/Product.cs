namespace OnLineShop2026.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public string PathImage { get; set; }
        
        public Product(string name, string description, decimal cost, string pathImage):this()
        {
            
            Name = name;
            Description = description;
            PathImage = pathImage;
            Cost = cost;
        }

        public Product() 
        {
            Id = Guid.NewGuid();
        }

        public override string ToString()
        {
            return $"Товар {Name}, Описание {Description}, Цена {Cost}";
        }
    }
}
