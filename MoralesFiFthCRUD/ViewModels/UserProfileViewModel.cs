using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoralesFiFthCRUD.ViewModels
{
    public class UserProfileViewModel
    {
        public int id { get; set; }
        public int ?phonenumber { get; set; }
        public string username { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
    }
}