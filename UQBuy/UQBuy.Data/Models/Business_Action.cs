using System;
using System.Collections.Generic;

namespace UQBuy.Data.Models
{
    public partial class Business_Action
    {
        public string BA_ID { get; set; }
        public string U_ID { get; set; }
        public string B_ID { get; set; }
        public Nullable<int> BA_Type { get; set; }
        public Nullable<System.DateTime> BA_CreateDate { get; set; }
        public string BA_Mark { get; set; }
        public virtual Business Business { get; set; }
        public virtual Userbasic Userbasic { get; set; }
    }
}
