namespace EFCORE.Models.Entities
{
    public class AppUser: BaseEntity
    {
        public string  UserName { get; set; }
        public int Password { get; set; }

           

        //Relational Properties

        public virtual AppUserProfile Profile { get; set; } 

        public virtual  List<Order> Orders { get; set; }
    }
}
