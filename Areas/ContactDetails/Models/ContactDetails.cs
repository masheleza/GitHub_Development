using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Areas.ContactDetails.Models
{
    public class ContactDetails
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Address HomeAddress { get; set; }
        public Phone HomePhone { get; set; }
        public Phone CellPhone { get; set; }
    }

    public class Phone
    {
        public string CountryCode { get; set; }
        public string AreaCode { get; set; }
        public string PhoneNumber { get; set; }
    }

    public class Address
    {
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
    }
}