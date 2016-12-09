using System;
using System.Collections.Generic;
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
        public string UserEmail { get; set; }

        public string UserPassword { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }

    }
}