using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BeltExam.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http; //Session
using System.Text.RegularExpressions;

namespace BeltExam.Controllers
{
    public class HomeController : Controller
    {
        private BeltContext dbContext;

        // here we can "inject" our context service into the constructor
        public HomeController(BeltContext context) => dbContext = context;

        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        //Logout********
        [HttpGet("Logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        // Register
        [HttpPost("Register")]
        public IActionResult Register(User user)
        {
            // Check initial ModelState
            if (ModelState.IsValid)
            {
                // If a User exists with provided email
                if (dbContext.Users.Any(u => u.Email == user.Email))
                {
                    // Manually add a ModelState error to the Email field, with provided
                    // error message
                    ModelState.AddModelError("Email", "Email already in use!");
                    return View("Index");
                    // You may consider returning to the View at this point
                }
                else
                {
                    //check password having at least 1 number, 1 special character
                    string password = user.Password;
                    Regex len = new Regex("^.{8,}$");
                    Regex num = new Regex("\\d");
                    Regex alpha = new Regex("\\D");
                    Regex special = new Regex("[><%#@]"); // Put  here more special characters

                    if (len.IsMatch(password) && num.IsMatch(password) && alpha.IsMatch(password) && special.IsMatch(password))
                    {
                        // successful match - write your code here
                        PasswordHasher<User> Hasher = new PasswordHasher<User>();
                        user.Password = Hasher.HashPassword(user, user.Password);
                        dbContext.Add(user);
                        // OR dbContext.Users.Add(newUser);
                        dbContext.SaveChanges();
                        // add into the session
                        User NewAcc = dbContext.Users.FirstOrDefault(u => u.Email == user.Email);
                        HttpContext.Session.SetInt32("UserId", user.UserId);
                        return RedirectToAction("Dashboard");
                    }
                    else
                    {
                        ModelState.AddModelError("Password", "Password should have at least 1 number, 1 letter and 1 special Charater");
                        return View("index");
                    }


                }
            }
            else
            {
                Console.WriteLine("AHIIAHIAIAHIAHIAHIAI_______-___----------");
                return View("Index");
            }

        }

        //Signin Link
        [HttpPost("SignIn")]
        public IActionResult SignIn(LoginUser userSubmission)
        {
            if (ModelState.IsValid)
            {
                // If inital ModelState is valid, query for a user with provided email
                var userInDb = dbContext.Users.FirstOrDefault(u => u.Email == userSubmission.LoginEmail);
                // If no user exists with provided email
                if (userInDb == null)
                {
                    // Add an error to ModelState and return to View!
                    ModelState.AddModelError("LoginEmail", "Invalid Email.");
                    return View("Index");
                }
                else
                {
                    // Initialize hasher object
                    var hasher = new PasswordHasher<LoginUser>();

                    // varify provided password against hash stored in db
                    var result = hasher.VerifyHashedPassword(userSubmission, userInDb.Password, userSubmission.LoginPassword);

                    // result can be compared to 0 for failure
                    if (result == 0)
                    {
                        // handle failure (this should be similar to how "existing email" is handled)
                        ModelState.AddModelError("LoginPassword", "Invalid Password.");
                        return View("Index");
                    }
                    else
                    {
                        User user1 = dbContext.Users.FirstOrDefault(u => u.Email == userSubmission.LoginEmail);
                        HttpContext.Session.SetInt32("UserId", user1.UserId);
                        return RedirectToAction("Dashboard");
                    }
                }

            }
            else
            {
                return View("Index");
            }
        }

        [HttpGet("Dashboard")]
        public IActionResult Dashboard()
        {
            ViewBag.SameDate= TempData["Samedate"];
            int? id = HttpContext.Session.GetInt32("UserId");
            User CurUser = dbContext.Users.FirstOrDefault(x => x.UserId == id);
            // Console.WriteLine(CurUser);
            ViewBag.CurUser = CurUser; //put in viewbag current user
            //Call All of Acts out.
            List<Models.Activity> AllActs = dbContext.Activities.Include(u => u.Creator).Include(u => u.UserToAct).ThenInclude(user=>user.Users).ToList();
            IEnumerable<Models.Activity> All_Acts = AllActs.OrderByDescending(a => a.CreatedAt);
            ViewBag.AllActs = All_Acts ;
           

            return View("Dashboard");
        }
        [HttpGet("NewAct")]
        public IActionResult NewAct()
        {
            int? id = HttpContext.Session.GetInt32("UserId");
            User CurUser = dbContext.Users.FirstOrDefault(x => x.UserId == id);
            ViewBag.User1 = CurUser;
            return View("NewAct");
        }
        [HttpPost("Create")]
        public IActionResult Create(Models.Activity act)
        {
            if (ModelState.IsValid){
            dbContext.Add(act);
            dbContext.SaveChanges();
            
            Models.Activity act1 = dbContext.Activities.FirstOrDefault(a=>a.Title== Request.Form["Title"]);
            Console.WriteLine("----------------???????????");
            Console.WriteLine(act1);
            return RedirectToAction("Detail", new{id=act1.ActivityId});
            }
            else{
                int? id = HttpContext.Session.GetInt32("UserId");
                User CurUser = dbContext.Users.FirstOrDefault(x => x.UserId == id);
                ViewBag.User1 = CurUser;
                return View("NewAct");
            }
        }
        [HttpGet("Detail/{id}")]
        public IActionResult Detail(int id){
            //Call out Loginuser
            int? idUser = HttpContext.Session.GetInt32("UserId");
            User CurUser = dbContext.Users.FirstOrDefault(x => x.UserId == idUser);
            ViewBag.CurUser = CurUser;
            //call out Activity
            Models.Activity ThisAct= dbContext.Activities
            .Include(u => u.Creator)
            .Include(thisact => thisact.UserToAct)
            .ThenInclude(u => u.Users)
            .FirstOrDefault(a=>a.ActivityId==id); 
            ViewBag.DeAct= ThisAct;
            // call out
          
            
            return View("Detail");
        }
        [HttpGet("Join/{id}")]
        public IActionResult Join(int id){
            //call out login user
            int? Userid = HttpContext.Session.GetInt32("UserId");
            //check time out
            Models.Activity Delact = dbContext.Activities.FirstOrDefault(d => d.ActivityId == id);
            DateTime thisDay = Delact.Date; //Date of activity want to join
            //all acts of this user joined*************
            User newUser = dbContext.Users.Include(c => c.ActForUser).ThenInclude(b => b.Activities).FirstOrDefault(us => us.UserId == Userid);
            bool errorDate = false;
            foreach(var e in newUser.ActForUser){
                
                if(e.Activities.Date == thisDay){
                    errorDate= true;
                    // ModelState.AddModelError("Date", "You have plan to go to another wedding on that day already!!!");
                    // ViewBag.samedayrs = "You have plan to go to another activity on that day already!!!";
                }
            }
            if(errorDate ==true){
                TempData["Samedate"]="Sorry. You are busy this day. just 1 Activity per day";
                
                return RedirectToAction("Dashboard");
            }
            
            // create Attendance
            Attendance newAtt = new Attendance();
            newAtt.UserId =(int)Userid;
            newAtt.ActivityId =id;
            dbContext.Attendances.Add(newAtt);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }
        [HttpGet("Leave/{id}")]
        public IActionResult Leave(int id){
            int? Userid = HttpContext.Session.GetInt32("UserId");
            Attendance thisAtt= dbContext.Attendances.FirstOrDefault(e=>e.UserId==Userid);
            dbContext.Attendances.Remove(thisAtt);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpGet("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            Models.Activity Delact = dbContext.Activities.FirstOrDefault(d => d.ActivityId == id); //call out wedding wants to delet
            dbContext.Activities.Remove(Delact); //remove from table named as weddings
            dbContext.SaveChanges();
            return RedirectToAction("DashBoard");
        }
    } //Not put code after this
}
