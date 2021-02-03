using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedialCare.Areas.Account.Data
{
    [Serializable]
    public class UserLogin
    {
        public int userID { get; set; }
        public string  userName{ get; set; }
    }
}
