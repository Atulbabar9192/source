﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Brainworks.ATM.Data
{
  public  class Card
    {
        public int Id { get; set; }
        public string CardNumber { get; set; }
        public int  ExpiryMonth { get; set; }
        public int  ExpiryYear { get; set; }
        public int  CVV { get; set; }
        public int  Pin { get; set; }
        public string  CardName{ get; set; }
        public int  StatusId{ get; set; }
        public int  AccountId{ get; set; }
        public Status Status { get; set; }
        public Account Account { get; set; }
    }
}
