using System;
using System.Collections.Generic;

namespace UQBuy.Data.Models
{
    public partial class Role_Relation
    {
        public string RR_ID { get; set; }
        public string U_ID { get; set; }
        public string UR_ID { get; set; }
        public virtual User_Role User_Role { get; set; }
        public virtual Userbasic Userbasic { get; set; }
    }
}
