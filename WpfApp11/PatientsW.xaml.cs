using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApp11.Clinic3DataSetTableAdapters;
using static MaterialDesignThemes.Wpf.Theme.ToolBar;

namespace WpfApp11
{
    public partial class PatientsW : Window
    {
        
        private Clinic3Entities context = new Clinic3Entities();
        public PatientsW()
        {
            InitializeComponent();
            PatientsViewGrd.ItemsSource = context.PatientsView2.ToList();
            PatientsCbx.ItemsSource = context.PatientsView2.ToList();
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
        private void Search_Click(object sender, RoutedEventArgs e)
        {
            string searchText = SearchTextBox.Text;
            PatientsCbx.SelectedItem = null;
            PatientsViewGrd.ItemsSource = context.PatientsView2.ToList().Where(item => item.PatientSurname.Contains(SearchTextBox.Text));
            SearchTextBox.Text = searchText;
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            SearchTextBox.Text = null;
            PatientsViewGrd.ItemsSource = context.PatientsView2.ToList();
            PatientsCbx.SelectedItem = null;
        }

        private void PatientsCbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SearchTextBox.Text = null;
            var selectedPatient = PatientsCbx.SelectedItem as PatientsView2;
            if (selectedPatient != null)
            {
                PatientsViewGrd.ItemsSource = context.PatientsView2.ToList().Where(item => item.PatientSurname == selectedPatient.PatientSurname);
            }
        }


    }
}   

