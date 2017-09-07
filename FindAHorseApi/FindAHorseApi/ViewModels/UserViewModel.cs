using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FindAHorseApi.ViewModels
{
    public class UserViewModel
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ProfilePicture { get; set; }
    }
}