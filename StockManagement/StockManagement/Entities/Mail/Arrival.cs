﻿// Mariam Ait Al
// 2017

using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Entities.Mail
{
    public class Arrival:BaseEntity
    {
        public DateTime ArrivalDate { get; set; }
        public LocalizedString Object { get; set; }
        public LocalizedString Type { get; set; }
        public LocalizedString Designation { get; set; }
        public int Number { get; set; }
        public LocalizedString Observations { get; set; }


        public Arrival()
        {
            ArrivalDate = DateTime.Now;
        }

        // Relations
        public MailConfiguration Configuration { get; set; }
        public Reciever Receiver { get; set; }
        public Sender Sender { get; set; }
    }
}