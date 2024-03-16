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
using WpfApp11.Clinic2DataSetTableAdapters;

namespace WpfApp11
{
    public partial class PatientsW : Window
    {
        PatientsTableAdapter patient = new PatientsTableAdapter();
        public PatientsW()
        {
            InitializeComponent();
            PatientsView2.ItemsSource = null;
            PatientsView2.Items.Clear();
            PatientsView2.ItemsSource = patient.GetData();
        }
    }
}
