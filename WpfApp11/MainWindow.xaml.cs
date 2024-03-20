using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static WpfApp11.Clinic3DataSet;

namespace WpfApp11
{
    
        public partial class MainWindow : Window
        {
            public MainWindow()
            {
                InitializeComponent();
               
            }
            private void Patients_Click(object sender, RoutedEventArgs e)
            {
                PatientsW window1 = new PatientsW();
                window1.ShowDialog();
                if (window1.DialogResult == false)
                {
                    window1.Close();
                }
            }

            private void Doctors_Click(object sender, RoutedEventArgs e)
            {
                DoctorsW window2 = new DoctorsW();
                window2.ShowDialog();
                if (window2.DialogResult == false)
                {
                    window2.Close();
                }
            }

            private void Appointments_Click(object sender, RoutedEventArgs e)
            {
                AppointmentsW window3 = new AppointmentsW();
                window3.ShowDialog();
                if (window3.DialogResult == false)
                {
                    window3.Close();
                }
            }
        }
    
}
