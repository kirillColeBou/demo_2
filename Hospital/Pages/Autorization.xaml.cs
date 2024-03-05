using Hospital.Classes;
using Hospital.Models;
using System;
using System.Collections.Generic;
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

namespace Hospital.Pages
{
    /// <summary>
    /// Логика взаимодействия для Autorization.xaml
    /// </summary>
    public partial class Autorization : Page
    {
        DoctorContext Context = new DoctorContext();
        bool AcceptAutorization = false;
        
        public Autorization()
        {
            InitializeComponent();
        }

        private void AutorizationClick(object sender, RoutedEventArgs e)
        {
            if(LoginDoctor.Text == "")
            {
                MessageBox.Show("Введите логин!");
                return;
            }
            if (PasswordDoctor.Password == "")
            {
                MessageBox.Show($"{LoginDoctor.Text}, введите ваш пароль!");
                return;
            }
            foreach (Doctor item in Context.Doctor)
            {
                if (LoginDoctor.Text == item.Login && PasswordDoctor.Password == item.Password)
                {
                    MessageBox.Show($"Здравствуйте, {LoginDoctor.Text}!");
                    AcceptAutorization = true;
                    MainWindow.mainWindow.OpenPages(new Pages.Main());
                }
                if (AcceptAutorization == false)
                    if (LoginDoctor.Text != item.Login)
                    {
                        MessageBox.Show("Такого логина пользователя нету!");
                        return;
                    }
                    else if (LoginDoctor.Text == item.Login && PasswordDoctor.Password != item.Password)
                    {
                        MessageBox.Show($"{LoginDoctor.Text}, ваш пароль неверный.\nПовторите попытку!");
                        return;
                    }
            }
        }
    }
}
