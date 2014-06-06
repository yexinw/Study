using System;
using System.Collections.Generic;

namespace UQBuy.Data.Models
{
    public partial class User_Remark
    {
        public string UR_ID { get; set; }
        public string U_ID { get; set; }
        public string UR_Title { get; set; }
        public string UR_Content { get; set; }
        public Nullable<System.DateTime> UR_StartDate { get; set; }
        public Nullable<System.DateTime> UR_EndDate { get; set; }
        public Nullable<System.DateTime> UR_CreateDate { get; set; }
        public Nullable<int> UR_Status { get; set; }
        public Nullable<int> UR_State { get; set; }
        public virtual Userbasic Userbasic { get; set; }
    }
}
