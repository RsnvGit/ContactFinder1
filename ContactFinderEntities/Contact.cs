using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactFinderEntities
{
    public class Contact
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]     
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        public string TelNumber { get; set; }
        public string MailAdress { get; set; }
        public string Relationship { get; set; }

        public bool RecentCalls { get; set; }
        public bool IgnoredContacts { get; set; }
    }
}
