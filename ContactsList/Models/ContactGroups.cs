using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ContactsList.Models
{
    class ContactGroup : ObservableCollection<ContactInfo>
    {
        public string GroupName { get; set; }

        public ContactGroup(string groupName, IEnumerable<ContactInfo> contacts)
            : base(contacts)
        {
            GroupName = groupName;
        }
    }
}
