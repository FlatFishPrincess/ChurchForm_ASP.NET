using System;
namespace ChurchDb.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        public String Phone { get; set; }
        public String Residential_num { get; set; }
        public String Email { get; set; }
        public Person Person { get; set; }
        public int PersonID { get; set; }
    }
}
