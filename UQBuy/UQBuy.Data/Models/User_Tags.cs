using System;
using System.Collections.Generic;

namespace UQBuy.Data.Models
{
    public partial class User_Tags
    {
        public User_Tags()
        {
            this.Tags_Relation = new List<Tags_Relation>();
        }

        public string UT_ID { get; set; }
        public string U_ID { get; set; }
        public string UT_Name { get; set; }
        public Nullable<System.DateTime> UT_CreateDate { get; set; }
        public Nullable<int> UT_State { get; set; }
        public virtual ICollection<Tags_Relation> Tags_Relation { get; set; }
        public virtual Userbasic Userbasic { get; set; }
    }
}
