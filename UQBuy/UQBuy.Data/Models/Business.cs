using System;
using System.Collections.Generic;

namespace UQBuy.Data.Models
{
    public partial class Business
    {
        public Business()
        {
            this.Business_Action = new List<Business_Action>();
            this.Business_Pic = new List<Business_Pic>();
        }

        public string B_ID { get; set; }
        public string U_ID { get; set; }
        public string E_ID { get; set; }
        public string B_Code { get; set; }
        public string B_Name { get; set; }
        public Nullable<int> B_Type { get; set; }
        public string B_Des { get; set; }
        public Nullable<System.DateTime> B_CreateDate { get; set; }
        public Nullable<System.DateTime> B_EffectiveTime { get; set; }
        public Nullable<int> B_EffectiveStatus { get; set; }
        public Nullable<System.DateTime> B_EndDate { get; set; }
        public Nullable<int> B_State { get; set; }
        public virtual ICollection<Business_Action> Business_Action { get; set; }
        public virtual Enterprise Enterprise { get; set; }
        public virtual Userbasic Userbasic { get; set; }
        public virtual ICollection<Business_Pic> Business_Pic { get; set; }
    }
}
