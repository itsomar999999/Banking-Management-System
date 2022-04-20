using DataLayer.Models;
using LogicLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestBankApp.Controllers
{
    public class ManagerHomeController : Controller
    {
        Interface1 obj;
        public ManagerHomeController(Interface1 _obj)
        {
            obj = _obj;
        }
        [IsManager]
        public IActionResult Index()
        {
            //string admType = HttpContext.Session.GetString("Role");
            
          //  if (admType == "Manager")
           // {
                string id = HttpContext.Session.GetString("EmpId");
                AdminDetail result = obj.GetAdminbyId(id);
                return View(result);
           // }                   
           // else
           //     return RedirectToAction("Login","Admin");
        }
        [IsManager]
        public IActionResult ViewRequests()
        {
            List<Request> result = obj.GetAllRequests();
            return View(result);
        }
        [IsManager]
        public IActionResult ApproveRequest(int id)
        {
            string Eid = HttpContext.Session.GetString("EmpId");
            obj.ApproveRequest(id,Eid);
            return RedirectToAction("ViewRequests");
        }
        [IsManager]
        public IActionResult RejectRequest(int id)
        {
            string Eid = HttpContext.Session.GetString("EmpId");
            obj.RejectRequest(id);
            return RedirectToAction("ViewRequests");
        }
        [IsManager]
        public IActionResult UpdateHistory()
        {
            List<UpdateHistory> result = new();
            if(TempData["ID"] == null)
            {
                result = obj.ViewUpHist();
            }
            else
            {
                string id = TempData["ID"].ToString();
                result = obj.ViewUpHist(id);
            }
            return View(result);
        }

        [HttpPost]
        public IActionResult UpdateHistory(string id)
        {
            TempData["ID"] = id;
            return RedirectToAction("UpdateHistory");
        }
        [IsManager]
        public IActionResult ViewAllUser()
        {
            List<AccountDetail> result = new();
            if (TempData["_ID"] == null)
            {
                result = obj.ViewUsers();
            }
            else
            {
                string id = TempData["_ID"].ToString();
                result = obj.ViewUsers(id);
            }
            return View(result);
        }
        [HttpPost]
        public IActionResult ViewAllUser(string id)
        {
            TempData["_ID"] = id;
            return RedirectToAction("ViewAllUser");
        }
        [IsManager]
        public IActionResult Details(string id)
        {
            CustomerDetail result = obj.GetCusDetailsId(id);
            return View(result);
        }
        public IActionResult ViewTransactHist(string id)
        {
            List<TransactionHistory> result = new();
            if (TempData["D1"] == null)
            {
                result = obj.ViewStateAdm(id);
            }
            else
            {
                string d1 = TempData["D1"].ToString();
                string d2 = TempData["D2"].ToString();
                result = obj.ViewStateAdm(id, d1, d2);
            }
            return View(result);
        }
        [HttpPost]
        public IActionResult ViewTransactHist(string Date1, string Date2)
        {
            TempData["D1"] = Date1.ToString();
            TempData["D2"] = Date2.ToString();
            return RedirectToAction("ViewTransactHist");
        }
        [IsManager]
        public IActionResult Suspend(string id)
        {
            AccountDetail result = obj.GetAccDetbyId(id);
            return View(result);
        }
        [IsManager]
        public IActionResult ConfirmSuspend(string id)
        {
            string Eid = HttpContext.Session.GetString("EmpId");
            obj.Suspend(id,Eid);
            return RedirectToAction("Suspended");
        }
        [IsManager]
        public IActionResult Suspended()
        {
            return View();
        }
        [IsManager]
        public IActionResult Activate(string id)
        {
            AccountDetail result = obj.GetAccDetbyId(id);
            return View(result);
        }
        [IsManager]
        public IActionResult ConfirmActivate(string id)
        {
            string Eid = HttpContext.Session.GetString("EmpId");
            obj.Activate(id, Eid);
            return RedirectToAction("Activated");
        }
        [IsManager]
        public IActionResult Activated()
        {
            return View();
        }
        [IsManager]
        public IActionResult Close(string id)
        {
            AccountDetail result = obj.GetAccDetbyId(id);
            return View(result);
        }
        [IsManager]
        public IActionResult ConfirmClose(string id)
        {
            string Eid = HttpContext.Session.GetString("EmpId");
            obj.Close(id,Eid);
            return RedirectToAction("Closed");
        }
        [IsManager]
        public IActionResult Closed()
        {
            return View();
        }
        [IsManager]
        public IActionResult EditAdmPass()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EditAdmPass(AdminAccount model)
        {
            string id = HttpContext.Session.GetString("EmpId");
            string msg = obj.EditAdmPass(id, model);
            if (msg == "Password has been changed")
            {
                TempData["yes"] = msg.ToString();
            }
            else
            {
                TempData["no"] = msg.ToString();
            }
            return RedirectToAction("EditAdmPass");
        }
        [IsManager]
        public IActionResult ViewAllEmp()
        {
            List<AdminDetail> result = new();
            if (TempData["_ID"] == null)
            {
                result = obj.ViewEmp();
            }
            else
            {
                string id = TempData["_ID"].ToString();
               // AdminDetail ad = obj.ViewEmp(id).FirstOrDefault();
                if (obj.ViewEmp(id).FirstOrDefault() == null)
                {
                    result = obj.ViewEmp();
                }
                else
                {
                    result = obj.ViewEmp(id);
                }
            }
            return View(result);
        }
        [HttpPost]
        public IActionResult ViewAllEmp(string id)
        {
            TempData["_ID"] = id;
            return RedirectToAction("ViewAllEmp");
        }
    }
}
