namespace EFCORE.Models.Entities
{
    public class Order:BaseEntity
    {
        public string ShippingAdreess { get; set; }

        public int? AppUserID { get; set; }  

        //Relationl Properties

        public virtual AppUser User { get; set; }

        public virtual List<OrderDetail> OrderDetails { get; set;}

    }
}
