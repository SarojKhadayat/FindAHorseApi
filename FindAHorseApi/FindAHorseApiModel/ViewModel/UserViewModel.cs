﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAHorseApiModel.ViewModel
{
    public class UserViewModel
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ProfilePicture { get; set; }
        public string TownOrCity { get; set; }
        public string PostCode { get; set; }
        public string Country { get; set; }
        public int UserType { get; set; }
    }
}