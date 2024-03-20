using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApp11.Clinic3DataSet1TableAdapters;


namespace WpfApp11
{
    public partial class AppointmentsW : Window
    {
        private AppointmentsView2TableAdapter priems = new AppointmentsView2TableAdapter();



        public AppointmentsW()
        {
            InitializeComponent();
            AppointmentsViewGrd.ItemsSource = priems.GetData();
            DoctorCbx.ItemsSource = priems.GetData();

        }
        private void Search_Click(object sender, RoutedEventArgs e)
        {
            AppointmentsViewGrd.ItemsSource = priems.SearchByDoctor(SearchTextBox.Text);
        }



        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            SearchTextBox.Text = null;
            AppointmentsViewGrd.ItemsSource = priems.GetData();
        }



        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        private void DoctorCbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SearchTextBox.Text = null;
            string doctorFullName = (DoctorCbx.SelectedItem as DataRowView)["DoctorFullName"].ToString();
            AppointmentsViewGrd.ItemsSource = priems.FilterByDoc(doctorFullName);
        }
    }
}