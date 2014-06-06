using System;
using System.Collections.Generic;

namespace UQBuy.Data.Models
{
    public partial class User_Visitcard
    {
        public string UV_ID { get; set; }
        public string U_ID { get; set; }
        public string Member_U_ID { get; set; }
        public Nullable<int> UV_Status { get; set; }
        public virtual Userbasic Userbasic { get; set; }
        public virtual Userbasic Userbasic1 { get; set; }
    }
}
