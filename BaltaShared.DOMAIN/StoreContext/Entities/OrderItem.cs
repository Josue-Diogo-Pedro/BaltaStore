namespace BaltaShared.DOMAIN.StoreContext.Entities;

public class OrderItem
{
    public OrderItem(Product product, decimal quantity)
    {
        Product = product;
        Quantity = quantity;
        Price = product.Price;
    }

    public Product Product { get; private set; }
    public decimal Quantity { get; private set; }
    public decimal Price { get; private set; }
}
