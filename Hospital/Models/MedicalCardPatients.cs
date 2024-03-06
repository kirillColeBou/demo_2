using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital.Models
{
    public class MedicalCardPatients
    {
        public int Id { get; set; }
        public int PatientsId { get; set; }
        public string Information { get; set; }
        public string Descriptions { get; set; }
        public string Diagnosis { get; set; }
        public string Recomendations { get; set; }
        public string Recipe { get; set; }
        public string NamePreparation { get; set; }
        public string Dosage { get; set; }
        public string ReceptionFormat { get; set; }
        public string Direction { get; set; }
        public bool Research { get; set; }
        public string Procedures { get; set; }
    }
}
