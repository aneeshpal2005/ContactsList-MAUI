using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ContactsList.Models
{
    public class ContactInfo
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Phone { get; set; }
        public required string Description { get; set; }
        public required string Photo { get; set; }

    }
}
