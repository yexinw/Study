using System;
using System.Collections.Generic;

namespace UQBuy.Data.Models
{
    public partial class User_Service_Action
    {
        public string USA_ID { get; set; }
        public string U_ID { get; set; }
        public string ES_ID { get; set; }
        public string E_ID { get; set; }
        public virtual Enterprise Enterprise { get; set; }
        public virtual Enterprise_Services Enterprise_Services { get; set; }
        public virtual Userbasic Userbasic { get; set; }
    }
}
