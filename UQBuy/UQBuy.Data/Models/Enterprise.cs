using System;
using System.Collections.Generic;

namespace UQBuy.Data.Models
{
    public partial class Enterprise
    {
        public Enterprise()
        {
            this.Businesses = new List<Business>();
            this.Enterprise_Action = new List<Enterprise_Action>();
            this.Enterprise_Services_Action = new List<Enterprise_Services_Action>();
            this.User_Service_Action = new List<User_Service_Action>();
            this.Userbasics = new List<Userbasic>();
        }

        public string E_ID { get; set; }
        public string U_ID { get; set; }
        public string TI_ID { get; set; }
        public string BL_ID { get; set; }
        public string E_Code { get; set; }
        public string E_Name { get; set; }
        public string E_MainWork { get; set; }
        public string E_Explain { get; set; }
        public string E_Des { get; set; }
        public string E_VideoLink { get; set; }
        public Nullable<int> E_Status { get; set; }
        public Nullable<System.DateTime> E_CreateDate { get; set; }
        public Nullable<int> E_State { get; set; }
        public virtual ICollection<Business> Businesses { get; set; }
        public virtual ICollection<Enterprise_Action> Enterprise_Action { get; set; }
        public virtual Enterprise_Level Enterprise_Level { get; set; }
        public virtual Type_Industry Type_Industry { get; set; }
        public virtual Userbasic Userbasic { get; set; }
        public virtual ICollection<Enterprise_Services_Action> Enterprise_Services_Action { get; set; }
        public virtual ICollection<User_Service_Action> User_Service_Action { get; set; }
        public virtual ICollection<Userbasic> Userbasics { get; set; }
    }
}
