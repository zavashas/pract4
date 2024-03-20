using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using WpfApp11.Clinic3DataSetTableAdapters;
namespace WpfApp11
{
    public partial class SpecializationsW : Window
    {
        private SpecializationsTableAdapter spec = new SpecializationsTableAdapter();
       

        public SpecializationsW()
        {
            InitializeComponent();
            Specializations.ItemsSource = spec.GetData();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

    }
    
}
