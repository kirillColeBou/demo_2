using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Position { get; set; }
    }
}
