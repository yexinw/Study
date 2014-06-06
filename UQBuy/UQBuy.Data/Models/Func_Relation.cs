using System;
using System.Collections.Generic;

namespace UQBuy.Data.Models
{
    public partial class Func_Relation
    {
        public string FR_ID { get; set; }
        public string UR_ID { get; set; }
        public string RF_ID { get; set; }
        public virtual Role_Function Role_Function { get; set; }
        public virtual User_Role User_Role { get; set; }
    }
}
