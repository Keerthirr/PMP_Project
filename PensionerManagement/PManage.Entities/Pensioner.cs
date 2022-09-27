using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PManage.Entities
{
    public class Pensioner
    {
        public int PensionerID { get; set; }
        public string AadharID { get; set; }
        public string Names { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string MobileNo { get; set; }
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public string PensionAmount { get; set; }
        public string Reason { get; set; }
    }
}
