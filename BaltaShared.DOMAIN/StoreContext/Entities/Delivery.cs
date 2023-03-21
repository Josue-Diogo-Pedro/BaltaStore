using BaltaShared.DOMAIN.StoreContext.Enums;

namespace BaltaShared.DOMAIN.StoreContext.Entities
{
    public class Delivery
    {
        public Delivery(DateTime estimateDeliveryDate)
        {
            CreateDate = DateTime.Now;
            EstimateDeliveryDate = estimateDeliveryDate;
            Status = EDeliveryStatus.Waiting;
        }

        public DateTime CreateDate { get; set; }
        public DateTime EstimateDeliveryDate { get; set; }
        public EDeliveryStatus Status { get; set; }

        public void Ship()
        {
            // Se a data de estimada de entrega for no passado, não efetuar a entrega!
            Status = EDeliveryStatus.Shipped;
        }

        public void Cancel()
        {
            // Se o Status já foi entregue, não pode cancelar
            Status = EDeliveryStatus.Canceled;
        }
    }
}
