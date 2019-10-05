namespace AppPhone.Models
{
    public enum TypeContact
    {
        PhoneNumber,
        Email,
        Faceboock,
        Twitter,
        LinkedIN
    }


    public class Phone
    {
        public int PhoneID { get; set; }
        public string Name { get; set; }
        public TypeContact Type { get; set; }
        public string Contact { get; set; }

    }
}
