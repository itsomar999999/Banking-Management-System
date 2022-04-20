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
    public class AdminController : Controller
    {
        Interface1 obj;
        public AdminController(Interface1 _obj)
        {
            obj = _obj;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            var vm = new AdminAccount
            {
                Roles = new List<RoleVm>
                {
                    new RoleVm {Id = 1, RoleName = "Manager"},
                    new RoleVm {Id = 2, RoleName = "Employee"}
                }
            };
            return View(vm);
        }
        [HttpPost]
        public IActionResult Register(AdminAccount model)
        {
            if (((model.SelectedRole == 1 && model.AdminPasskey == "1111") || (model.SelectedRole == 2 && model.AdminPasskey == "0000")))
            {
                if (obj.AddAdmin(model))
                {
                    TempData["Success"] = "true";
                    return RedirectToAction("Success");
                }
                else
                {
                    TempData["Message"] = "Username already exists!";
                    return RedirectToAction("Register");
                }
            } 
            else
            {
                TempData["Message"] = "Incorrect admin passkey";
                return RedirectToAction("Register");
            }
        }
        public IActionResult Success()
        {
            var flag = TempData["Success"];
            if (flag != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Register");
            }
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(AdminAccount model)
        {
            string[] tempStr = obj.AdminLogin(model);
            if (tempStr[0] != null)
            {
                HttpContext.Session.SetString("Role", tempStr[0]);
                HttpContext.Session.SetString("EmpId", tempStr[1]);

                string admType = HttpContext.Session.GetString("Role");
                if (admType == "Manager")
                {
                    return RedirectToAction("Index", "ManagerHome");
                }
                else
                {
                    return RedirectToAction("Index", "EmployeeHome");
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

    public class IsManager : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var session = filterContext.HttpContext.Session;
            if (session.GetString("Role") == "Manager")
                return;

            var redirectTarget = new RouteValueDictionary{
                            {"action", "Index"},
                            {"controller", "Admin"},
                           
            };
            filterContext.Result = new RedirectToRouteResult(redirectTarget);
            
        }
    }

    public class IsEmployee : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var session = filterContext.HttpContext.Session;
            if (session.GetString("Role") == "Employee")
                return;

            var redirectTarget = new RouteValueDictionary{
                            {"action", "Index"},
                            {"controller", "Admin"},

            };
            filterContext.Result = new RedirectToRouteResult(redirectTarget);

        }
    }
}
