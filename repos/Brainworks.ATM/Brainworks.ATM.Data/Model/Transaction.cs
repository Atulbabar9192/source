using System;
using System.Collections.Generic;
using System.Text;

namespace Brainworks.ATM.Data
{
     public class Transaction
    {
        public int ID { get; set; }
        public string TranscationNumber { get; set; }
        public int TransactionTypeId { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal Amount{ get; set; }
        public int StatusId { get; set; }
        public int DepositModeID { get; set; }
        public  TransactionType TransactionType { get; set; }
        public Status Status { get; set; }
        public DepositMode  DepositMode  { get; set; }
    }
}
