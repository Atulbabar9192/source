using System;
using System.Collections.Generic;
using System.Text;

namespace Brainworks.ATM.Data
{
   public    class DepositMode
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Transaction> Transactions { get; set; }
    }
}
