using System;
using System.Collections.Generic;

namespace DataVaksin.Models
{
    public partial class Login
    {
        public int Email { get; set; }
        public string Password { get; set; }
        public string Jabatan { get; set; }
    }
}
