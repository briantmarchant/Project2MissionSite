using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Project2MissionSite.Models
{
    [Table("Mission")]
    public class Mission
    {
        [Key]
        public int MissionID { get; set; }

        [DisplayName("Mission")]
        public string MissionName { get; set; }

        [DisplayName("President First Name")]
        public string MissionPresFirstName { get; set; }

        [DisplayName("President Last Name")]
        public string MissionPresLastName { get; set; }

        [DisplayName("Mission Home Address")]
        public string MissionHomeAddress { get; set; }

        [DisplayName("City")]
        public string MissionCity { get; set; }

        [DisplayName("State/Province")]
        public string MissionStateOrProvince { get; set; }

        [DisplayName("Country")]
        public string MissionCountry { get; set; }

        [DisplayName("Language")]
        public string MissionLanguage { get; set; }

        [DisplayName("Climate")]
        public string MissionClimate { get; set; }

        [DisplayName("Dominant Religion")]
        public string MissionDominantReligion { get; set; }

        public string MissionFlag { get; set; }
        
    }
}