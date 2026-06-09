using OnLineShop2026.Models;

namespace OnLineShop2026.Data
{
    public class CartRepositoryInMemory : ICartRepository
    {
        private static List<Cart> carts = new List<Cart>();
        
        public void Add(Product product, int idUser)
        {
            var cart = carts.FirstOrDefault(x => x.UserId == idUser);
            if (cart == null)
            { 
                var new_cart = new Cart();
                new_cart.Id = new Guid();
                new_cart.UserId = idUser; 
                new_cart.Add(product);
                carts.Add(new_cart);
            }
            else
            {
                var cartItem = cart.CartItems.FirstOrDefault(x => x.Product.Id == product.Id);
                if (cartItem == null)
                    cart.Add(product);
                else
                {
                    cartItem.Amount += 1;
                }
            }
        }

            
        public void Increment(Product product, int idUser)
        {
            Cart cart = carts.FirstOrDefault(x => x.UserId == idUser);
            CartItem item = cart.CartItems.FirstOrDefault(x => x.Product.Id == product.Id);
            if(item != null)
                item.Amount += 1;
        }

        public void Decrement(Product product, int idUser)
        {
            Cart cart = carts.FirstOrDefault(x => x.UserId == idUser);
            CartItem item = cart.CartItems.FirstOrDefault(x => x.Product.Id == product.Id);
            if (item != null)
                if (item.Amount > 1)
                    item.Amount -= 1;
                else
                { 
                    cart.CartItems.Remove(item);
                }
        }

        public Cart? TryGetByUserId(int userId) 
        {
            return carts.FirstOrDefault(x => x.UserId == userId);
        }

    }
}
