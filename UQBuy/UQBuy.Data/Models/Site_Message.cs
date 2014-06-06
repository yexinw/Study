using System;
using System.Collections.Generic;

namespace UQBuy.Data.Models
{
    public partial class Site_Message
    {
        public string SM_ID { get; set; }
        public string From_U_ID { get; set; }
        public string To_U_ID { get; set; }
        public string SM_Messae { get; set; }
        public Nullable<System.DateTime> SM_CreateDate { get; set; }
        public Nullable<int> SM_Type { get; set; }
        public Nullable<int> SM_Status { get; set; }
        public virtual Userbasic Userbasic { get; set; }
        public virtual Userbasic Userbasic1 { get; set; }
    }
}
