using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebDemo1.Models
{
    public class RegisterModel
    {
        public string Name { get; set; }
        public string CardNo { get; set; }
        
        public string Email { get; set; }
        public bool Registered { get; set; } 
    }
}