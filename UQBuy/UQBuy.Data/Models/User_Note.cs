using System;
using System.Collections.Generic;

namespace UQBuy.Data.Models
{
    public partial class User_Note
    {
        public string UN_ID { get; set; }
        public string U_ID { get; set; }
        public string UN_Title { get; set; }
        public string UN_Content { get; set; }
        public string UN_Color { get; set; }
        public Nullable<int> UN_Status { get; set; }
        public Nullable<int> UN_PageX { get; set; }
        public Nullable<int> UN_PageY { get; set; }
        public Nullable<int> UN_PageZ { get; set; }
        public Nullable<System.DateTime> UN_CreateDate { get; set; }
        public Nullable<int> UN_State { get; set; }
        public virtual Userbasic Userbasic { get; set; }
    }
}
