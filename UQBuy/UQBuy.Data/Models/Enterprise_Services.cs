using System;
using System.Collections.Generic;

namespace UQBuy.Data.Models
{
    public partial class Enterprise_Services
    {
        public Enterprise_Services()
        {
            this.Enterprise_Level_Relation = new List<Enterprise_Level_Relation>();
            this.Enterprise_Services_Action = new List<Enterprise_Services_Action>();
            this.User_Service_Action = new List<User_Service_Action>();
        }

        public string ES_ID { get; set; }
        public string ES_Name { get; set; }
        public string ES_Des { get; set; }
        public Nullable<System.DateTime> ES_CreateDate { get; set; }
        public Nullable<int> ES_State { get; set; }
        public virtual ICollection<Enterprise_Level_Relation> Enterprise_Level_Relation { get; set; }
        public virtual ICollection<Enterprise_Services_Action> Enterprise_Services_Action { get; set; }
        public virtual ICollection<User_Service_Action> User_Service_Action { get; set; }
    }
}
