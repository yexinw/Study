using System;
using System.Collections.Generic;

namespace UQBuy.Data.Models
{
    public partial class Enterprise_Services_Action
    {
        public string USA_ID { get; set; }
        public string U_ID { get; set; }
        public string ES_ID { get; set; }
        public string E_ID { get; set; }
        public Nullable<System.DateTime> USA_EndDate { get; set; }
        public Nullable<System.DateTime> USA_CreateDate { get; set; }
        public Nullable<int> USA_Count { get; set; }
        public string USA_Des { get; set; }
        public virtual Enterprise Enterprise { get; set; }
        public virtual Enterprise_Services Enterprise_Services { get; set; }
    }
}
