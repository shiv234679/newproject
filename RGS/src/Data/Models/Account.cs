using Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Models
{
    public class Account : BaseModel
    {
        [Key]
        public long UserId { get; set; }
        public string UserName { get; set; }
        public string MobileNumber { get; set; }
        public string EmailId { get; set; }
        public UserType UserType { get; set; }
        public string Address { get; set; }
        public string Image { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; }
        public bool IsPassChanged { get; set; }
        public int? OTP { get; set; }
        public DateTime? OTPDateTime { get; set; }
    }
}
