using DataLayer.Models;
using LogicLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestBankApp.Controllers
{
    public class UserHomeController : Controller
    {
        Interface1 obj;
        public UserHomeController(Interface1 _obj)
        {
            obj = _obj;
        }
        [IsUser]
        public IActionResult Index()
        {
            string admType = HttpContext.Session.GetString("Role");
            if (admType == "User")
            {
                string id = HttpContext.Session.GetString("AccId");

                AccountDetail a = obj.GetAccDetbyId(id);
                return View(a);
            }
            else
            {
                return RedirectToAction("Login", "User");
            }
        }
        [IsUser]
        public IActionResult Add_Bnf()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add_Bnf(Beneficiary model)
        {
            model.AccId = HttpContext.Session.GetString("AccId");
            int ps = obj.AddBnf(model);
            if (ps == 1)
            {
                TempData["CorrectBnf"] = "Beneficiary added successfully";
                return RedirectToAction("Add_Bnf");
            }
            else if (ps == 2)
            {
                TempData["WrongBnf"] = "Beneficiary alreay exists";
                return RedirectToAction("Add_Bnf");
            }
            else if (ps == 3)
            {
                TempData["WrongBnf"] = "Account doesn't exist";
                return RedirectToAction("Add_Bnf");
            }
            else
            {
                TempData["WrongBnf"] = "Cannot add own account as beneficiary";
                return RedirectToAction("Add_Bnf");
            }
        }
        [IsUser]
        public IActionResult Remove_Bnf(int Id)
        {
            obj.RemoveBnf(Id);
            return RedirectToAction("TransferFunds");
        }
        [IsUser]
        public IActionResult TransferFunds()
        {
            List<Beneficiary> result = new();


            if (TempData["Bid"] == null)
            {
                string id = HttpContext.Session.GetString("AccId");
                result = obj.GetAllBnf(id);
            }
            else
            {
                string bid = TempData["Bid"].ToString();
                string id = HttpContext.Session.GetString("AccId");
                result = obj.GetBnfId(id, bid);
            }
            return View(result);
        }
        [HttpPost]
        public IActionResult TransferFunds(string BId)
        {

            TempData["Bid"] = BId.ToString();

            return RedirectToAction("TransferFunds");
        }
        [IsUser]
        public IActionResult Transfer(int Id)
        {
            string id = Convert.ToString(Id);
            HttpContext.Session.SetString("BID", id);
            Beneficiary b = obj.GetBnfbyId(Id);
            return View(b);
        }
        [HttpPost]
        public IActionResult Transfer(string Amount)
        {
            float Amt = Convert.ToSingle(Amount);
            string bid = HttpContext.Session.GetString("BID");
            if (obj.Transfer(bid, Amt))
            {
                return RedirectToAction("TransferSuccess");
            }
            else
            {
                return RedirectToAction("Transfer");
            }
        }
        [IsUser]
        public IActionResult TransferSuccess()
        {
            return View();
        }
        [IsUser]
        public IActionResult ViewStatement()
        {
            List<TransactionHistory> result = new();


            if (TempData["D1"] == null)
            {
                string id = HttpContext.Session.GetString("AccId");
                result = obj.ViewState(id);
            }
            else
            {
                string d1 = TempData["D1"].ToString();
                string d2 = TempData["D2"].ToString();
                string id = HttpContext.Session.GetString("AccId");
                result = obj.ViewStatebyDate(id, d1, d2);
            }
            return View(result);
        }
        [HttpPost]
        public IActionResult ViewStatement(string Date1, string Date2)
        {
            TempData["D1"] = Date1.ToString();
            TempData["D2"] = Date2.ToString();
            return RedirectToAction("ViewStatement");
        }
        [IsUser]
        public IActionResult Profile()
        {
            string id = HttpContext.Session.GetString("CusId");
            CustomerDetail cd = obj.GetCusDetailsId(id);
            return View(cd);
        }
        [IsUser]
        public IActionResult EditPass()
        {
            return View();
        }
        [HttpPost]
        public IActionResult EditPass(CustomerAccount model)
        {
            string id = HttpContext.Session.GetString("AccId");
            string msg = obj.ChangePass(id, model);
            if (msg == "Password has been changed")
            {
                TempData["yes"] = msg.ToString();
            }
            else
            {
                TempData["no"] = msg.ToString();
            }
            return RedirectToAction("EditPass");
        }
        [IsUser]
        public IActionResult reReg()
        {
            return View();
        }
        [HttpPost]
        public IActionResult reReg(CustomerAccount model)
        {
            model.CusId = HttpContext.Session.GetString("CusId");
            obj.reReg(model);
            HttpContext.Session.SetString("Status", "rPending");
            return RedirectToAction("Index");
        }
        [IsUser]
        public IActionResult EditProfile()
        {
            string id = HttpContext.Session.GetString("CusId");
            CustomerDetail res = obj.GetCusDetailsId(id);
            CustomerAccount result = obj.GetCustAccwithDet(res);
            return View(result);
        }
        [HttpPost]
        public IActionResult EditProfile(CustomerAccount model)
        {
            obj.EditDetails(model);
            return RedirectToAction("Index");
        }
    } 
}
