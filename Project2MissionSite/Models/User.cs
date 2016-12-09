using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Project2MissionSite.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [EmailAddress]
        [DisplayName("Email Address")]
        public string UserEmail { get; set; }

        [DisplayName("Password")]
        public string UserPassword { get; set; }

        [DisplayName("First Name")]
        public string UserFirstName { get; set; }

        [DisplayName("Last Name")]
        public string UserLastName { get; set; }

    }
}