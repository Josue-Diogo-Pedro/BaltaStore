using BaltaShared.DOMAIN.StoreContext.Enums;

namespace BaltaShared.DOMAIN.StoreContext.Entities;

public class Order
{
    private readonly IList<OrderItem> _items;
    private readonly IList<Delivery> _deliveries;
    public Order(Customer customer)
    {
        Customer = customer;
        CreateDate = DateTime.Now;
        Status = EOrderStatus.Created;
        _items = new List<OrderItem>();
        _deliveries = new List<Delivery>(); ;
    }

    public Customer Customer { get; private set; }
    public string Number { get; private set; }
    public DateTime CreateDate { get; private set; }
    public EOrderStatus Status { get; private set; }
    public IReadOnlyCollection<OrderItem> Items => _items.ToArray();
    public IReadOnlyCollection<Delivery> Deliveries => _deliveries.ToArray();

    public void AddItem(OrderItem item)
    {
        // Valida item
        // Adiciona pedido
        _items.Add(item);
    }

    // Criar um pedido
    public void Place()
    {
        // Gera o número do pedido
        Number = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 8).ToUpper();

        // Validar
    }

    // Pagar um pedido
    public void Pay()
    {
        Status = EOrderStatus.Paid;
    }

    // Enviar um pedido
    public void Ship()
    {
        // A cada 5 produtos é uma entrega
        var deliveries = new List<Delivery>();
        deliveries.Add(new Delivery(DateTime.Now.AddDays(5)));
        var count = 1;
        
        //Quebra todas as entregas
        foreach (var item in _items)
        {
            if(count == 5)
            {
                count = 1;
                deliveries.Add((new Delivery(DateTime.Now.AddDays(5)));
            }
            count++;
        }

        // Envia todas as entregas
        deliveries.ForEach(x => x.Ship());
        
        // Adiciona todas entregas ao pedido
        deliveries.ForEach(x => _deliveries.Add(x));

    }

    // Cancelar um pedido
    public void Cancel()
    {
        Status = EOrderStatus.Canceled;
        _deliveries.ToList().ForEach(x => x.Cancel());
    }
}
