using System;

namespace OnLineShop2026.Models
{
    public class Cart
    {
       
        public Guid Id { get; set; }
        public int UserId { get; set; }
        public List<CartItem> CartItems { get; set; }
        public decimal Cost 
        {
            get
                { 
                    return CartItems.Sum(x => x.Cost);
                }
            set { } 
        
        }

        public void Add(Product product)
        {
            this.CartItems.Add(new CartItem() { Product = product, Amount = 1 });
        }

        public Cart()
        {
            CartItems = new List<CartItem>();
        }
    }
}
