using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ChurchDb.Models;

namespace ChurchDb.Models
{
    public class ViewModel
    {   
        public IEnumerable<Person> Persons { get; set; }
        public IEnumerable<Contact> Contacts { get; set; }
    }
}
