using System;
using System.Collections.Generic;
using System.Text;

namespace Brainworks.ATM.Data
{
   public  class Account
    {
        public int Id { get; set; }
        public string CustomerNumber { get; set; }
        public string AccountNumber { get; set; }
        public int UserId { get; set; } 
       public int AccountTypeId{ get; set; }
        public decimal AvilableBalance{ get; set; }
        public int StatusId{ get; set; }
        public  User User{ get; set; }
        public  AccountType AccountType { get; set; }
        public  Status Status{ get; set; }
        public List<Card> Cards { get; set; }
    }
}
