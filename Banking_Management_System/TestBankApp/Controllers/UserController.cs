using DataLayer.Models;
using LogicLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestBankApp.Controllers
{
    public class UserController : Controller
    {
        Interface1 obj;
        public UserController(Interface1 _obj)
        {
            obj = _obj;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(CustomerAccount model)
        {
            if (obj.AddUser(model))
            {
                return RedirectToAction("Success");
            }
            else
            {
                TempData["Message"] = "Username already exists!";
                return RedirectToAction("Register");
            }
        }
        public IActionResult Success()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(CustomerAccount model)
        {

            string[] arr = obj.UserLogin(model);
            if (arr[0] != null)
            {
                HttpContext.Session.SetString("Role", "User");
                HttpContext.Session.SetString("AccId", arr[0]);
                HttpContext.Session.SetString("CusId", arr[1]);
                HttpContext.Session.SetString("Status", arr[2]);
                if(HttpContext.Session.GetString("Status") == "Rejected" || HttpContext.Session.GetString("Status") == "Inactive")
                {
                    return RedirectToAction("Index", "UserHome");
                }
                else
                {
                    HttpContext.Session.SetString("FName", arr[3]);
                    return RedirectToAction("Index", "UserHome");
                }   
            }
            else
            {
                TempData["Message"] = "Invalid details!";
                return RedirectToAction("Login");
            }
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }

    public class IsUser : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var session = filterContext.HttpContext.Session;
            if (session.GetString("Role") == "User")
                return;

            var redirectTarget = new RouteValueDictionary{
                            {"action", "Index"},
                            {"controller", "User"},

            };
            filterContext.Result = new RedirectToRouteResult(redirectTarget);

        }
    }
}
