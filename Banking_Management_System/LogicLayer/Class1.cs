using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LogicLayer
{
    public class Class1:Interface1
    {
        BankTestContext db;
        public Class1()
        {
            db = new BankTestContext();
        }

        public bool AddUser(CustomerAccount m)
        {
            bool flag = db.CustomerAccounts.Any(cus => cus.CuserName == m.CuserName);

            if (!flag)
            {
                CustomerAccount ca = new();
                CustomerDetail cd = new();
                AccountDetail ad = new();
                Request r = new();

                string ACstr = "AC_";
                string Cstr = "C_";

                List<CustomerDetail> CusDet = db.CustomerDetails.ToList();
                List<AccountDetail> AccDet = db.AccountDetails.ToList();

                if (CusDet.Count == 0)
                {
                    Cstr = "C_10001";
                }
                else
                {
                    var lastID = CusDet[CusDet.Count - 1];
                    string tempstr1 = lastID.CusId;
                    int tempNum = Convert.ToInt32(tempstr1.Substring(2)) + 1;
                    Cstr += Convert.ToString(tempNum);
                }


                if (AccDet.Count == 0)
                {
                    ACstr = "AC_10001";
                }
                else
                {
                    var lastID = AccDet[AccDet.Count - 1];
                    string tempstr1 = lastID.AccId;
                    int tempNum = Convert.ToInt32(tempstr1.Substring(3)) + 1;
                    ACstr += Convert.ToString(tempNum);
                }

                cd.CusId = Cstr;
                cd.Fname = null;
                cd.Lname = null;
                cd.Email = null;
                cd.PhoneNumber = null;
                cd.Pan = null;
                cd.Aadhaar = null;
                cd.Address = null;

                r.RequestStatus = "rPending";
                r.CusId = cd.CusId;
                r.Fname = m.Fname;
                r.Lname = m.Lname;
                r.Email = m.Email;
                r.PhoneNumber = m.PhoneNumber;
                r.Pan = m.Pan;
                r.Aadhaar = m.Aadhaar;
                r.Address = m.Address;

                ad.AccId = ACstr;
                ad.CusId = cd.CusId;
                ad.Balance = 0;
                ad.Status = "Inactive";

                ca.AccId = ad.AccId;
                ca.CuserName = m.CuserName;
                ca.Cpassword = m.Cpassword;

                db.CustomerDetails.Add(cd);
                db.Requests.Add(r);
                db.AccountDetails.Add(ad);
                db.CustomerAccounts.Add(ca);
                db.SaveChanges();

                return true;
            }
            else
            {
                return false;
            }
        }

        public string[] UserLogin(CustomerAccount ca)
        {
            bool flag = db.CustomerAccounts.Any(cus => cus.CuserName == ca.CuserName);
            string[] str = new string[4] { null, null, null, null };
            if (flag)
            {
                CustomerAccount ca1 = db.CustomerAccounts.Where(a => a.CuserName == ca.CuserName).FirstOrDefault();        
                if (ca1.Cpassword == ca.Cpassword1)
                {
                    AccountDetail ad = db.AccountDetails.Where(b => b.AccId == ca1.AccId).FirstOrDefault();
                    CustomerDetail cd = db.CustomerDetails.Where(c => c.CusId == ad.CusId).FirstOrDefault();
                    str[0] = ca1.AccId;
                    str[1] = ad.CusId;
                    str[2] = ad.Status;
                    str[3] = cd.Fname;
                }
            }
            return str;
        }

        public AccountDetail GetAccDetbyId(string id)
        {
            AccountDetail ad = db.AccountDetails.Where(a => a.AccId == id).FirstOrDefault();
            return ad;
        }

        public List<Beneficiary> GetAllBnf(string id)
        {
            List<Beneficiary> b = db.Beneficiaries.Where(a => a.AccId == id).ToList();
            return b;
        }

        public int AddBnf(Beneficiary b)
        {
            if(b.AccId != b.BAccId)
            {
                if(db.AccountDetails.Any(a => a.AccId == b.BAccId)){
                    List<Beneficiary> b1 = db.Beneficiaries.Where(a => a.AccId == b.AccId).ToList();
                    bool flag = b1.Any(a => a.BAccId == b.BAccId);
                    if (!flag)
                    {
                        Beneficiary b2 = new();
                        AccountDetail ad = db.AccountDetails.Where(a => a.AccId == b.BAccId).FirstOrDefault();
                        CustomerDetail cd = db.CustomerDetails.Where(c => c.CusId == ad.CusId).FirstOrDefault();

                        b2.AccId = b.AccId;
                        b2.BAccId = b.BAccId;
                        b2.BName = cd.Fname;

                        db.Beneficiaries.Add(b2);
                        db.SaveChanges();

                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
                else
                {
                    return 3;
                }
                
            }           
            else
            {
                return 4;
            }
        }

        public List<Beneficiary> GetBnfId(string id,string Bid)
        {
                List<Beneficiary> b = db.Beneficiaries.Where(a => a.AccId == id && a.BAccId == Bid).ToList();
                return b;          
        }
        
        public Beneficiary GetBnfbyId(int Bid)
        {
            Beneficiary b = db.Beneficiaries.Where(a => a.BId == Bid).FirstOrDefault();
            return b;
        }

        public bool Transfer(string bid, float amt)
        {
            TransactionHistory th = new();
            TransactionHistory th2 = new();
            Beneficiary b = db.Beneficiaries.Where(a => a.BId == Convert.ToInt32(bid)).FirstOrDefault();
            AccountDetail ad2 = db.AccountDetails.Where(a => a.AccId == b.BAccId).FirstOrDefault();
            AccountDetail ad1 = db.AccountDetails.Where(a => a.AccId == b.AccId).FirstOrDefault();

            if(ad1.Balance > amt)
            {
                ad1.Balance -= amt;
                ad2.Balance += amt;
                
                th.AccId = ad1.AccId;
                th.Type = "Debited";
                th.Amount = amt;
                th.Date = DateTime.Now.ToString("dd/MM/yyyy h:mm tt");
                th.Receiver = ad2.AccId;
                th.Balance = ad1.Balance;

                th2.AccId = ad2.AccId;
                th2.Type = "Credited";
                th2.Amount = amt;
                th2.Date = DateTime.Now.ToString("dd/MM/yyyy h:mm tt");
                th2.Receiver = ad2.AccId;
                th2.Balance = ad2.Balance;

                db.TransactionHistories.Add(th);
                db.TransactionHistories.Add(th2);
                db.SaveChanges();

                return true;
            }
            else
            {
                return false;
            }
        }

        public List<TransactionHistory> ViewState(string id)
        {
            List<TransactionHistory> th = db.TransactionHistories.Where(a => a.AccId == id).ToList();
            return th;
        }

        public List<TransactionHistory> ViewStatebyDate(string id,string D1, string D2)
        
        {
            DateTime Date1 = DateTime.Parse(D1);
            DateTime Date2 = DateTime.Parse(D2);
            List<TransactionHistory> _th = db.TransactionHistories.Where(a => a.AccId == id).ToList();
            List<TransactionHistory> th = new();
            foreach(var i in _th)
            {
                bool flag = DateTime.Parse(i.Date) >= Date1 && DateTime.Parse(i.Date) <= Date2;
                if (flag)
                {
                    th.Add(i);
                }                
            }
            return th;
        }

        public CustomerDetail GetCusDetailsId(string id)
        {
            CustomerDetail cd = db.CustomerDetails.Where(a => a.CusId == id).FirstOrDefault();
            return cd;
        }

        public string ChangePass(string id, CustomerAccount ca)
        {
            CustomerAccount ca1 = db.CustomerAccounts.Where(a => a.AccId == id).FirstOrDefault();
            if(ca1.Cpassword == ca.Cpassword)
            {
                if(ca1.Cpassword != ca.NewCpassword)
                {
                    ca1.Cpassword = ca.NewCpassword;
                    db.SaveChanges();

                    return "Password has been changed";
                }
                else { return "New Password cannot be same as old one"; }
            }
            else { return "Password is wrong"; }
        }

        public void reReg(CustomerAccount m)
        {
            Request r = new();
            AccountDetail ad = db.AccountDetails.Where(a => a.CusId == m.CusId).FirstOrDefault();
            r.RequestStatus = "rPending";
            r.CusId = m.CusId;
            r.Fname = m.Fname;
            r.Lname = m.Lname;
            r.Email = m.Email;
            r.PhoneNumber = m.PhoneNumber;
            r.Pan = m.Pan;
            r.Aadhaar = m.Aadhaar;
            r.Address = m.Address;

            ad.Status = "Inactive";

            db.Requests.Add(r);
            db.SaveChanges();
        }

        public void RemoveBnf(int Bid)
        {
            Beneficiary b = db.Beneficiaries.Where(a => a.BId == Convert.ToInt32(Bid)).FirstOrDefault();
            db.Beneficiaries.Remove(b);
            db.SaveChanges();
        }




        //Manager
        public bool AddAdmin(AdminAccount ar)
        {
            bool flag = db.AdminAccounts.Any(cus => cus.UserName == ar.UserName);
            if (!flag)
            {
                AdminAccount aa = new();
                AdminDetail ad = new();

                string str1 = "E_";
                List<AdminAccount> adm = db.AdminAccounts.ToList();

                if (adm.Count == 0)
                {
                    str1 = "E_101";
                }
                else
                {
                    var lastID = adm[adm.Count - 1];
                    string tempstr1 = lastID.EmpId;
                    int tempNum = Convert.ToInt32(tempstr1.Substring(2)) + 1;
                    str1 += Convert.ToString(tempNum);
                }

                aa.EmpId = str1;
                aa.UserName = ar.UserName;
                aa.Password = ar.Password;
                aa.AdminType = (ar.SelectedRole == 1) ? "Manager" : "Employee";
                ad.EmpId = aa.EmpId;
                ad.EmpName = ar.EmpName;
                ad.EmpPhone = ar.EmpPhone;
                db.AdminAccounts.Add(aa);
                db.AdminDetails.Add(ad);
                db.SaveChanges();
                return true;
            }

            else
                return false;
        }

        public string[] AdminLogin(AdminAccount la)
        {
            bool flag = db.AdminAccounts.Any(cus => cus.UserName == la.UserName);
            string[] str = new string[3] { null, null, null};
            if (flag)
            {
                AdminAccount aa = db.AdminAccounts.Where(a => a.UserName == la.UserName).FirstOrDefault();
                if (aa.Password == la.Password)
                {
                    str[0] = aa.AdminType;
                    str[1] = aa.EmpId;
                    return str;
                }
                else
                {
                    return str;
                }
            }
            else
            {
                return str;
            }
        }

        public List<Request> GetAllRequests()
        {
            List<Request> req = db.Requests.ToList();
            return req;
        }

        //rPending = registration pending
        //uPending = update pending
        public void ApproveRequest(int id, string Eid)
        {
            Request r = db.Requests.Where(a => a.RequestId == id).FirstOrDefault();
            CustomerDetail cd = db.CustomerDetails.Where(b => b.CusId == r.CusId).FirstOrDefault();
            AccountDetail ad = db.AccountDetails.Where(c => c.CusId == r.CusId).FirstOrDefault();
            UpdateHistory uh = new();

            uh.UpdaterId = Eid;
            uh.UpdateType = (r.RequestStatus == "rPending" ? "Added" : "Updated");
            uh.UpdatedId = cd.CusId;
            string str = $"{uh.UpdateType} the customer {cd.CusId} on {DateTime.Now.ToString("dd/MM/yyyy h:mm tt")} by {Eid}";
            uh.UpdateInfo = str;
            db.UpdateHistories.Add(uh);

            cd.Fname = r.Fname;
            cd.Lname = r.Lname;
            cd.Email = r.Email;
            cd.PhoneNumber = r.PhoneNumber;
            cd.Pan = r.Pan;
            cd.Aadhaar = r.Aadhaar;
            cd.Address = r.Address;
            
            if(r.RequestStatus == "rPending")
            {
                ad.Status = "Active";
            }
            db.SaveChanges();

            db.Requests.Remove(r);
            db.SaveChanges();
        }

        public void RejectRequest(int id)
        {
            Request r = db.Requests.Where(a => a.RequestId == id).FirstOrDefault();
            CustomerDetail cd = db.CustomerDetails.Where(b => b.CusId == r.CusId).FirstOrDefault();
            AccountDetail ad = db.AccountDetails.Where(c => c.CusId == r.CusId).FirstOrDefault();
            if(r.RequestStatus == "rPending")
            {
                ad.Status = "Rejected";
                db.SaveChanges();
            }
            db.Requests.Remove(r);
            db.SaveChanges();
        }

        public List<UpdateHistory> ViewUpHist( string id = "0")
        {
            List<UpdateHistory> uh = new();
            if (id == "0")
            {
                uh = db.UpdateHistories.ToList();
            }
            else
            {
                uh = db.UpdateHistories.Where(a => a.UpdatedId == id).ToList();
            }
            return uh;
        }

        public AdminDetail GetAdminbyId(string id)
        {
            return db.AdminDetails.Where(a => a.EmpId == id).FirstOrDefault();
        }

        public List<AccountDetail> ViewUsers(string id = "0")
        {
            List<AccountDetail> ad = new();
            if(id == "0")
            {
                ad = db.AccountDetails.ToList();
            }
            else
            {
                ad = db.AccountDetails.Where(a => a.AccId == id).ToList();
            }
            return ad;
        }

        public List<TransactionHistory> ViewStateAdm(string id, string D1 ="0", string D2 = "0")
        {
            AccountDetail ad = db.AccountDetails.Where(a => a.CusId == id).FirstOrDefault();
            List<TransactionHistory> th = new();
            if (D1 == "0")
            {
                th = db.TransactionHistories.Where(a => a.AccId == ad.AccId).ToList();
            }
            else
            {
                DateTime Date1 = DateTime.Parse(D1);
                DateTime Date2 = DateTime.Parse(D2);
                List<TransactionHistory> _th = db.TransactionHistories.Where(a => a.AccId == ad.AccId).ToList();
                foreach (var i in _th)
                {
                    bool flag = DateTime.Parse(i.Date) >= Date1 && DateTime.Parse(i.Date) <= Date2;
                    if (flag)
                    {
                        th.Add(i);
                    }
                }
            }           
            return th;
        }
        
        public void Suspend(string id, string Eid)
        {
            AccountDetail ad = db.AccountDetails.Where(a => a.AccId == id).FirstOrDefault();

            UpdateHistory uh = new();
            uh.UpdaterId = Eid;
            uh.UpdateType = "Suspended";
            uh.UpdatedId = ad.CusId;
            string str = $"{uh.UpdateType} the customer {ad.CusId} on {DateTime.Now.ToString("dd/MM/yyyy h:mm tt")} by {Eid}";
            uh.UpdateInfo = str;
            db.UpdateHistories.Add(uh);
            ad.Status = "Suspended";
            db.SaveChanges();
        }
        public void Activate(string id, string Eid)
        {
            AccountDetail ad = db.AccountDetails.Where(a => a.AccId == id).FirstOrDefault();

            UpdateHistory uh = new();
            uh.UpdaterId = Eid;
            uh.UpdateType = "Activated";
            uh.UpdatedId = ad.CusId;
            string str = $"{uh.UpdateType} the customer {ad.CusId} on {DateTime.Now.ToString("dd/MM/yyyy h:mm tt")} by {Eid}";
            uh.UpdateInfo = str;
            db.UpdateHistories.Add(uh);
            ad.Status = "Active";
            db.SaveChanges();
        }
        public void Close(string id, string Eid)
        {
            AccountDetail ad = db.AccountDetails.Where(a => a.AccId == id).FirstOrDefault();

            UpdateHistory uh = new();
            uh.UpdaterId = Eid;
            uh.UpdateType = "Closed";
            uh.UpdatedId = ad.CusId;
            string str = $"{uh.UpdateType} the customer {ad.CusId} on {DateTime.Now.ToString("dd/MM/yyyy h:mm tt")} by {Eid}";
            uh.UpdateInfo = str;
            db.UpdateHistories.Add(uh);
            ad.Status = "Active";
            ad.Status = "Closed";
            db.SaveChanges();
        }

        public string EditAdmPass(string id, AdminAccount aa)
        {
            AdminAccount aa1 = db.AdminAccounts.Where(a => a.EmpId == id).FirstOrDefault();
            if (aa1.Password == aa.Password)
            {
                if (aa1.Password != aa.Newpassword)
                {
                    aa1.Password = aa.Newpassword;
                    db.SaveChanges();

                    return "Password has been changed";
                }
                else { return "New Password cannot be same as old one"; }
            }
            else { return "Password is wrong"; }
        }

        public List<AdminDetail> ViewEmp(string id = "0")
        {
            List<AdminDetail> _ad = new();
            if (id == "0")
            {
                List<AdminAccount> aa = db.AdminAccounts.Where(a => a.AdminType == "Employee").ToList();
                AdminDetail ad = new();
                foreach (var i in aa)
                {
                    ad = db.AdminDetails.Where(a => a.EmpId == i.EmpId).FirstOrDefault();
                    _ad.Add(ad);
                }
            }
            else
            {
                if(db.AdminAccounts.Any(a => a.AdminType == "Employee" && a.EmpId == id))
                {
                    _ad = db.AdminDetails.Where(a => a.EmpId == id).ToList();
                }
            }
            return _ad;
        }


        //Employee
        public void EditDetails(CustomerAccount m)
        {
            Request r = new();

            r.RequestStatus = "uPending";
            r.CusId = m.CusId;
            r.Fname = m.Fname;
            r.Lname = m.Lname;
            r.Email = m.Email;
            r.PhoneNumber = m.PhoneNumber;
            r.Pan = m.Pan;
            r.Aadhaar = m.Aadhaar;
            r.Address = m.Address;

            db.Requests.Add(r);
            db.SaveChanges();
        }
        public bool Dep_With(string id, float amt, int t)
        {
            AccountDetail ad = db.AccountDetails.Where(a => a.AccId == id).FirstOrDefault();
            TransactionHistory th = new();
            if (t == 0)
            {
                ad.Balance += amt;
            }
            else
            {
                if(ad.Balance > amt)
                {
                    ad.Balance -= amt;
                }
                else
                {
                    return false;
                }
            }

            th.AccId = ad.AccId;
            th.Type = (t == 0 ? "Credited" : "Debited");
            th.Amount = amt;
            th.Date = DateTime.Now.ToString("dd/MM/yyyy h:mm tt");
            th.Receiver = ad.AccId;
            th.Balance = ad.Balance;

            db.TransactionHistories.Add(th);
            db.SaveChanges();

            return true;
        }
        public int Add_Bnf(string id, string bid)
        {
            Beneficiary b = new();
            b.AccId = id;
            b.BAccId = bid;
            if (b.AccId != b.BAccId)
            {
                if (db.AccountDetails.Any(a => a.AccId == b.BAccId))
                {
                    List<Beneficiary> b1 = db.Beneficiaries.Where(a => a.AccId == b.AccId).ToList();
                    bool flag = b1.Any(a => a.BAccId == b.BAccId);
                    if (!flag)
                    {
                        Beneficiary b2 = new();
                        AccountDetail ad = db.AccountDetails.Where(a => a.AccId == b.BAccId).FirstOrDefault();
                        CustomerDetail cd = db.CustomerDetails.Where(c => c.CusId == ad.CusId).FirstOrDefault();

                        b2.AccId = b.AccId;
                        b2.BAccId = b.BAccId;
                        b2.BName = cd.Fname;

                        db.Beneficiaries.Add(b2);
                        db.SaveChanges();

                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
                else
                {
                    return 3;
                }

            }
            else
            {
                return 4;
            }
        }

        public CustomerAccount GetCustAccwithDet(CustomerDetail res)
        {
            CustomerAccount ca = new();
            ca.CusId = res.CusId;
            ca.Fname = res.Fname;
            ca.Lname = res.Lname;
            ca.Email = res.Email;
            ca.PhoneNumber = res.PhoneNumber;
            ca.Pan = res.Pan;
            ca.Aadhaar = res.Aadhaar;
            ca.Address = res.Address;

            return ca;
        }

    }
}
