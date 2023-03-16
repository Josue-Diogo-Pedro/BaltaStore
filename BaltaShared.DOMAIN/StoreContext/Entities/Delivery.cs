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
    }
}
