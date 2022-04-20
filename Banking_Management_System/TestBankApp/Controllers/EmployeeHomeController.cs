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
    public class EmployeeHomeController : Controller
    {
        Interface1 obj;
        public EmployeeHomeController(Interface1 _obj)
        {
            obj = _obj;
        }
        [IsEmployee]
        public IActionResult Index()
        {
            string admType = HttpContext.Session.GetString("Role");

            if (admType == "Employee")
            {
                string id = HttpContext.Session.GetString("EmpId");
                AdminDetail result = obj.GetAdminbyId(id);
                return View(result);
            }
            else
                return RedirectToAction("Login", "Admin");
        }
        [IsEmployee]
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
        [IsEmployee]
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
        [IsEmployee]
        public IActionResult Details(string id)
        {
            CustomerDetail result = obj.GetCusDetailsId(id);
            return View(result);
        }
        [IsEmployee]
        public IActionResult EditDetails(string id)
        {
            CustomerDetail res = obj.GetCusDetailsId(id);
            CustomerAccount result = obj.GetCustAccwithDet(res);
            return View(result);
        }
        [HttpPost]
        public IActionResult EditDetails(CustomerAccount model)
        {            obj.EditDetails(model);
            return RedirectToAction("ViewAllUser");
        }
        [IsEmployee]
        public IActionResult Transact(string id)
        {
            AccountDetail a = obj.GetAccDetbyId(id);
            return View(a);
        }
        [IsEmployee]
        public IActionResult Deposit(string id)
        {
            AccountDetail a = obj.GetAccDetbyId(id);
            
            return View(a);
        }
        [HttpPost]
        public IActionResult Deposit(string id, float amt)
        {
            if (obj.Dep_With(id, amt, 0))
            {
                TempData["msg"] = "Deposit";
                return RedirectToAction("TransactSuccess");
            }
            else{
                return RedirectToAction("Deposit");
            }
        }
        [IsEmployee]
        public IActionResult Withdraw(string id)
        {
            AccountDetail a = obj.GetAccDetbyId(id);
            return View(a);
        }
        [HttpPost]
        public IActionResult Withdraw(string id, float amt)
        {
            if (obj.Dep_With(id, amt, 1))
            {
                TempData["msg"] = "Withdraw";
                return RedirectToAction("TransactSuccess");
            }
            else
            {
                return RedirectToAction("Withdraw");
            }
        }
        [IsEmployee]
        public IActionResult AddBnf(string id)
        {
            AccountDetail result = obj.GetAccDetbyId(id);
            return View(result);
        }
        [HttpPost]
        public IActionResult AddBnf(string id,string model)
        {
           
            int ps = obj.Add_Bnf(id,model);
            if (ps == 1)
            {
                TempData["CorrectBnf"] = "Beneficiary added successfully";
                return RedirectToAction("AddBnf");
            }
            else if (ps == 2)
            {
                TempData["WrongBnf"] = "Beneficiary alreay exists";
                return RedirectToAction("AddBnf");
            }
            else if (ps == 3)
            {
                TempData["WrongBnf"] = "Account doesn't exist";
                return RedirectToAction("AddBnf");
            }
            else
            {
                TempData["WrongBnf"] = "Cannot add own account as beneficiary";
                return RedirectToAction("AddBnf");
            }
        }
        [IsEmployee]
        public IActionResult TransferFunds(string id)
        {
            List<Beneficiary> result = new();


            if (TempData["Bid"] == null)
            {
              
                result = obj.GetAllBnf(id);
            }
            else
            {
                string bid = TempData["Bid"].ToString();
               
                result = obj.GetBnfId(id, bid);
            }
            return View(result);
        }
        [HttpPost]
        public IActionResult TransferFunds(string BId, string temp="0")
        {
            TempData["Bid"] = BId.ToString();
            return RedirectToAction("TransferFunds");
        }
        [IsEmployee]
        public IActionResult RemoveBnf(int Id)
        {
            obj.RemoveBnf(Id);
            return RedirectToAction("TransferFunds");
        }
        [IsEmployee]
        public IActionResult Transfer(int Id)
        {
            string id = Convert.ToString(Id);
            Beneficiary b = obj.GetBnfbyId(Id);
            return View(b);
        }
        [HttpPost]
        public IActionResult Transfer(string Amount, int Bid)
        {
            float Amt = Convert.ToSingle(Amount);
            string bid = Bid.ToString();
            if (obj.Transfer(bid, Amt))
            {
                TempData["msg"] = "Fund Transfer";
                return RedirectToAction("TransactSuccess");
            }
            else
            {
                return RedirectToAction("Transfer");
            }
        }
        [IsEmployee]
        public IActionResult TransactSuccess()
        {
            return View();
        }
        [IsEmployee]
        public IActionResult TransactHist(string id)
        {
            List<TransactionHistory> result = new();
            if (TempData["D1"] == null)
            {
                result = obj.ViewState(id);
            }
            else
            {
                string d1 = TempData["D1"].ToString();
                string d2 = TempData["D2"].ToString();
                result = obj.ViewStatebyDate(id, d1, d2);
            }
            return View(result);
        }
        [HttpPost]
        public IActionResult TransactHist(string Date1, string Date2)
        {
            TempData["D1"] = Date1.ToString();
            TempData["D2"] = Date2.ToString();
            return RedirectToAction("TransactHist");
        }
    }
}
