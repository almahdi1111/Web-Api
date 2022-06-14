using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Web_Api.Controllers;

namespace Web_Api
{
    public class CUSTOMER
    {
        public int Customer_ID { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(40, ErrorMessage = "The Name value cannot exceed 40 characters. ")]
        public string Customer_name { get; set;}
        [Required(ErrorMessage = "Customer_Address Name is required")]
        [StringLength(40, MinimumLength = 10, ErrorMessage = "Customer Address Name must be >10 and <40 character")]
        public string Customer_Address  { get; set;}
        public List<USER> user { get; set; }

    }
}
