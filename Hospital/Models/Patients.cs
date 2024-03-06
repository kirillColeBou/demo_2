using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital.Models
{
    public class Patients
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Surname { get; set; }

        public string ToFIO() => $"{Lastname} {Firstname} {Surname}";
    }
}
