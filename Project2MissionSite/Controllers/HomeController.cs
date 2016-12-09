using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project2MissionSite.Models;
using Project2MissionSite.DAL;
using System.Net;
using System.Web.Security;

namespace Project2MissionSite.Controllers
{
    public class HomeController : Controller
    {
        private MissionSiteContext db = new MissionSiteContext(); 

        [Authorize]
        public ActionResult Index(string whatever)
        {
            return View();

        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login( FormCollection form, bool rememberMe = false)
        {

            String email = form["Email address"].ToString();
            String password = form["Password"].ToString();

            var currentUser = db.Database.SqlQuery<User>(
                "SELECT * " +
                "FROM [User] " +
                "WHERE UserEmail = '" + email + "' AND UserPassword = '" + password + "';");

            if (currentUser.Count() > 0)
            {
                FormsAuthentication.SetAuthCookie(email, rememberMe);

                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            Session.Abandon();
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        // GET: Missions
        public ActionResult ChooseMission()
        {
            ViewBag.ChooseMission = db.Missions.ToList();

            return View();
        }

        public ActionResult MissionFAQ(int missionID)
        {
            IEnumerable<MissionQuestion> MissionQuestions = db.Database.SqlQuery<MissionQuestion>(
                "SELECT * " +
                "FROM MissionQuestions " +
                "WHERE MissionID = " + missionID + ";");

            Mission missions = db.Missions.Find(missionID);
            ViewBag.Missions = missions;
            return View(MissionQuestions);
        }

        // GET: Users/Create
        public ActionResult CreateUser()
        {
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateUser([Bind(Include = "UserID,UserEmail,UserPassword,UserFirstName,UserLastName")] User user)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(user);
        }
    }
}