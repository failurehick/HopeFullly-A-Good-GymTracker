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
    /// Interaction logic for PageActivity.xaml
    /// </summary>
    public partial class PageActivity : Page
    {
        public PageActivity()
        {
            InitializeComponent();
        }

        public PageActivity(Person personPassed)
        {
            InitializeComponent();
            //assign passed data to the module
            person = personPassed;

            //assign person to summary object
            summary.SessionPerson = person;

            //hide the inclined contorls 
            InclinedCheckBoxLabel.Visibility = Visibility.Hidden;
            InclinedCheckBox.Visibility = Visibility.Hidden;
        }
    }
}
