using System;
using System.Collections.Generic;

namespace UQBuy.Data.Models
{
    public partial class Enterprise_Action
    {
        public string EA_ID { get; set; }
        public string U_ID { get; set; }
        public string E_ID { get; set; }
        public Nullable<int> EA_Type { get; set; }
        public Nullable<System.DateTime> EA_CreateDate { get; set; }
        public string EA_Mark { get; set; }
        public virtual Enterprise Enterprise { get; set; }
        public virtual Userbasic Userbasic { get; set; }
    }
}
