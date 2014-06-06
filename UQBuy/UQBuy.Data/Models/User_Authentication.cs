using System;
using System.Collections.Generic;

namespace UQBuy.Data.Models
{
    public partial class User_Authentication
    {
        public string UA_ID { get; set; }
        public string U_ID { get; set; }
        public Nullable<int> UA_Type { get; set; }
        public string UA_Content { get; set; }
        public Nullable<System.DateTime> UA_CreateDate { get; set; }
        public Nullable<int> UA_Satus { get; set; }
        public virtual Userbasic Userbasic { get; set; }
    }
}
