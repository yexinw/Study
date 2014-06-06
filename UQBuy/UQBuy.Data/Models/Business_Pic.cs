using System;
using System.Collections.Generic;

namespace UQBuy.Data.Models
{
    public partial class Business_Pic
    {
        public string BP_ID { get; set; }
        public string B_ID { get; set; }
        public string BP_Des { get; set; }
        public string BP_Path { get; set; }
        public Nullable<int> BP_Level { get; set; }
        public virtual Business Business { get; set; }
    }
}
