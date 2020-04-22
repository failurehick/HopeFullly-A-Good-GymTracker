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

namespace GymTracker
{
    /// <summary>
    /// Interaction logic for PagePerson.xaml
    /// </summary>
    public partial class PagePerson : Page
    {
        internal bool formDataVaild = false;

        public PagePerson()
        {
            InitializeComponent();

            ClearControls();
        }

        /// <summary>
        /// Events rasied on click
        /// </summary>

        private void PagePersonClearButton_Click(object sender, RoutedEventArgs e)
        {
            ClearControls();
        }

        private void ActivitiesButton_Click(object sender, RoutedEventArgs e)
        {

        }


        private void ClearControls()
        {
            PersonNameTextBox.Text = string.Empty;
            PersonAgeTextBox.Text = string.Empty;
            PersonWeightTextBox.Text = string.Empty;
            PersonNameTextBox.Focus();
        }
    }
}
