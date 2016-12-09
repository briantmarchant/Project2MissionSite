using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project2MissionSite.Models;
using System.Data.Entity;

namespace Project2MissionSite.DAL
{
    public class MissionSiteContext : DbContext
    {
        public MissionSiteContext() : base("MissionSiteContext")
        {

        }
        public DbSet<Mission> Missions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<MissionQuestion> MissionQuestions { get; set; }
    }
}