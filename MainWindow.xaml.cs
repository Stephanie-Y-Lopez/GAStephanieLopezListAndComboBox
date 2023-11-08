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

namespace GAStephanieLopezListAndComboBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> firstNames = new List<string> { "Yolanda", "Nelly", "Alex", "Nico", "Diana" };
        List<string> lastNames = new List<string> { "Chavoya", "Montes", "Gonzales", "Luna", "Lopez" };
        public MainWindow()
        {
            InitializeComponent();
            cmbFirstName.ItemsSource = firstNames;
            lbLastNames.ItemsSource = lastNames;
        }

        private void btnDisplayFullName_Click(object sender, RoutedEventArgs e)
        {
            int firstNameIndex = cmbFirstName.SelectedIndex;
            int lastNameIndex = lbLastNames.SelectedIndex;

            string firstName = firstNames[firstNameIndex];
            string lastName = lastNames[lastNameIndex];

            string fullName = firstName + " " + lastName;

            MessageBox.Show(fullName);
        }

        private void btnAddNames_Click(object sender, RoutedEventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;

            firstNames.Add(firstName);
            lastNames.Add(lastName);

            cmbFirstName.Items.Refresh();
            lbLastNames.Items.Refresh();
        }

        private void btnRemoveStudentAtIndex_Click(object sender, RoutedEventArgs e)
        {
            int firstNameIndex = cmbFirstName.SelectedIndex;
            int lastNamesIndex = lbLastNames.SelectedIndex;

            firstNames.RemoveAt(firstNameIndex);
            lastNames.RemoveAt(lastNamesIndex);

            cmbFirstName.Items.Refresh();
            lbLastNames.Items.Refresh();
        }

        private void lbLastNames_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cmbFirstName.SelectedIndex = lbLastNames.SelectedIndex;
        }
    }
}
