namespace apiPhoneSecurity.Models
{
    using System.Data.Entity;

    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<apiPhoneSecurity.Models.Phone> Phones { get; set; }
    }
}