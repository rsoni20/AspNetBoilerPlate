using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ME.Entities
{
    public class Company:Entity<long>
    {
        public string Title { get; set; }
        public string PrimaryContactName { get; set; }
        public string SecondaryContactName { get; set; }
        public string PrimaryPhoneNumber { get; set; }
        public string SecondaryPhoneNumber { get; set; }
        public string LogoUrl { get; set; }
        public string PrimaryEmail { get; set; }
        public string SecondaryEmail { get; set; }
        public string Comments { get; set; }
        public string CorporateUrl { get; set; }
    }
}
