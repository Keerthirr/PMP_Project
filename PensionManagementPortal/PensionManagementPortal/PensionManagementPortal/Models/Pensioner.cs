using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PensionManagementPortal.Models
{
    public class Pensioner
    {
        [Key]
        public int PensionerId { get; set; }
        [RegularExpression(@"^([0-9]{12})$", ErrorMessage = "Invalid Aadhar")]
        public string AadharId { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Age is required")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Gender is required")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public string MobileNo { get; set; }
        [Required(ErrorMessage = "Bank Name is required")]
        public string BankName { get; set; }
        [Required(ErrorMessage = "Account Number is required")]
        public string AccountNumber { get; set; }
        [Required(ErrorMessage = "Pension Amount is required")]
        public string PensionAmount { get; set; }
        [Required(ErrorMessage = "Reason is required")]
        public string Reason { get; set; }
    }
}
