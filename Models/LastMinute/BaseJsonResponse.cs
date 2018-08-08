using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.LastMinute
{
    public class BaseJsonResponse
    {
        public bool IsSucess { get; set; } = true;
        public string message { get; set; }
        public string statuscode { get; set; } = "200";
    }
}
