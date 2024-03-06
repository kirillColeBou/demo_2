using Hospital.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hospital.Elements
{
    /// <summary>
    /// Логика взаимодействия для MedicalCardPatients.xaml
    /// </summary>
    public partial class MedicalCardPatients : UserControl
    {
        PatientContext Context = new PatientContext();
        public MedicalCardPatients(Models.MedicalCardPatients _medicalCardPatients)
        {
            InitializeComponent();
            PatientsId.Content = Context.Patients.Where(x => x.Id == _medicalCardPatients.PatientsId).First().ToFIO();
            Information.Content = _medicalCardPatients.Information;
            Descriptions.Content = _medicalCardPatients.Descriptions;
            Diagnosis.Content = _medicalCardPatients.Diagnosis;
            Recomendations.Content = _medicalCardPatients.Recomendations;
            Recipe.Content = _medicalCardPatients.Recipe;
            NamePreparation.Content = _medicalCardPatients.NamePreparation;
            Dosage.Content = _medicalCardPatients.Dosage;
            ReceptionFormat.Content = _medicalCardPatients.ReceptionFormat;
            Direction.Content = _medicalCardPatients.Direction;
            if(_medicalCardPatients.Research == false)
                Research.Content = "Бюджет";
            else if (_medicalCardPatients.Research == true)
                Research.Content = "Платно";
            Procedures.Content = _medicalCardPatients.Procedures;
        }

        private void UpdateInformation(object sender, RoutedEventArgs e) => MainWindow.mainWindow.OpenPages(new Pages.UpdateInformation());
    }
}
