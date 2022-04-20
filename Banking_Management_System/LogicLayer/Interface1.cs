using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public interface Interface1
    {
        public bool AddUser(CustomerAccount m);
        public string[] UserLogin(CustomerAccount ca);
        public AccountDetail GetAccDetbyId(string id);
        public bool AddAdmin(AdminAccount ar);
        public string[] AdminLogin(AdminAccount la);
        public List<Beneficiary> GetAllBnf(string id);
        public int AddBnf(Beneficiary b);
        public List<Beneficiary> GetBnfId(string id, string Bid);
        public Beneficiary GetBnfbyId(int Bid);
        public bool Transfer(string bid, float amt);
        public List<TransactionHistory> ViewState(string id);
        public List<TransactionHistory> ViewStatebyDate(string id, string Date1, string Date2);
        public CustomerDetail GetCusDetailsId(string id);
        public string ChangePass(string id, CustomerAccount ca);
        public void reReg(CustomerAccount m);
        public void RemoveBnf(int Bid);

        //Manager
        public List<Request> GetAllRequests();
        public void ApproveRequest(int id, string Eid);
        public List<UpdateHistory> ViewUpHist(string id = "0");
        public AdminDetail GetAdminbyId(string id);
        public List<AccountDetail> ViewUsers(string id = "0");
        public void RejectRequest(int id);
        public List<TransactionHistory> ViewStateAdm(string id, string D1 = "0", string D2 = "0");
        public void Suspend(string id, string Eid);
        public void Activate(string id, string Eid);
        public void Close(string id, string Eid);
        public string EditAdmPass(string id, AdminAccount aa);
        public List<AdminDetail> ViewEmp(string id = "0");

        //Employee
        public void EditDetails(CustomerAccount cd);
        public bool Dep_With(string id, float amt, int t);
        public int Add_Bnf(string id, string bid);
        public CustomerAccount GetCustAccwithDet(CustomerDetail res);
    }
}
