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
using System.Windows.Shapes;

namespace WpfApp11
{
    public partial class DoctorsW : Window
    {
        private Clinic3Entities context = new Clinic3Entities();

        public DoctorsW()
        {
            InitializeComponent();
            DoctorsCbx.ItemsSource = context.DoctorsView2.ToList();
            DoctorsViewGrd.ItemsSource = context.DoctorsView2.ToList();
            
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
        private void Search_Click(object sender, RoutedEventArgs e)
        {
            string searchText = SearchTextBox.Text;
            DoctorsCbx.SelectedItem = null;
            DoctorsViewGrd.ItemsSource = context.DoctorsView2.ToList().Where(item => item.SpecializationName.Contains(SearchTextBox.Text));
            SearchTextBox.Text = searchText;
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            SearchTextBox.Text = null;
            DoctorsViewGrd.ItemsSource = context.DoctorsView2.ToList();
            DoctorsCbx.SelectedItem = null;
        }
        private void DoctorsCbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SearchTextBox.Text = null;
            var selectedDoctor = DoctorsCbx.SelectedItem as DoctorsView2;
            if (selectedDoctor != null)
            {
                DoctorsViewGrd.ItemsSource = context.DoctorsView2.ToList().Where(item => item.SpecializationName == selectedDoctor.SpecializationName);
            }
        }

    }
}
    

