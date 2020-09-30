using System;

namespace PropertyDemo
{
   
  public  class Customer
    {
        int _Custid;
        string Cname;
        bool Status;
        double Balance;

        public Customer(int Custid, string Cname, bool status, double Balance )
        {
            _Custid = Custid;
            this.Cname = Cname;
            this.Status = status;
            this.Balance = Balance;
        }
        public int Custid
        {
            get { return _Custid; }
        }
    
    }

}
