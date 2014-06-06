using System;
using System.Collections.Generic;

namespace UQBuy.Data.Models
{
    public partial class User_Integral
    {
        public string UI_ID { get; set; }
        public string U_ID { get; set; }
        public Nullable<decimal> UI_Score { get; set; }
        public string UI_Des { get; set; }
        public Nullable<System.DateTime> UI_CreateDate { get; set; }
        public Nullable<int> UI_State { get; set; }
        public virtual Userbasic Userbasic { get; set; }
    }
}
