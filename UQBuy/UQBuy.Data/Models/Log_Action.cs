using System;
using System.Collections.Generic;

namespace UQBuy.Data.Models
{
    public partial class Log_Action
    {
        public string LA_ID { get; set; }
        public string U_ID { get; set; }
        public Nullable<int> LA_Type { get; set; }
        public Nullable<System.DateTime> LA_CreateTime { get; set; }
        public string LA_IP { get; set; }
        public string LA_Mark { get; set; }
        public virtual Userbasic Userbasic { get; set; }
    }
}
