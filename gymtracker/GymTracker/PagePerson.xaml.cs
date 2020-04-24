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
            //Get the forms data using the harvest data method
            //Generate a person with the data collected to pass on
            //to pageActiviyu

            var personData = HarvestData();
            if (formDataVaild)
            {
                var pageActivity = new PageActivity(personData);
                this.NavigationService.Navigate(pageActivity);
            }
        }


        private void ClearControls()
        {
            PersonNameTextBox.Text = string.Empty;
            PersonAgeTextBox.Text = string.Empty;
            PersonWeightTextBox.Text = string.Empty;
            PersonNameTextBox.Focus();
        }

        private Person HarvestData()
        {
            //Data Handler Variables
            var tempPerson = new Person();
            var countOfValidFields = 0;
            //Set The Rules In One Place
            var requiredValidFields = 3;
            //Use Try Catch
            try
            {
                //Validate the name and assign if there
                if (!string.IsNullOrEmpty(PersonNameTextBox.Text))
                {
                    tempPerson.PersonName = PersonNameTextBox.Text;
                    countOfValidFields += 1;
                }
                else
                {
                    MessageBox.Show("You must enter a name");
                }
                //Validate the Age and assign if there
                if (!string.IsNullOrEmpty(PersonAgeTextBox.Text))
                {
                    tempPerson.Age = Convert.ToInt32(PersonAgeTextBox.Text);
                    countOfValidFields += 1;
                }
                else
                {
                    MessageBox.Show("You must enter a Age");
                }
                //Validate the Weight and assign if there
                if (!string.IsNullOrEmpty(PersonWeightTextBox.Text))
                {
                    tempPerson.Weight = float.Parse (PersonWeightTextBox.Text);
                    countOfValidFields += 1;
                }
                else
                {
                    MessageBox.Show("You must enter a Weight");
                }

                //WARNING. 6:56 ON VID 17

            }
            catch (Exception)
            {

                throw;
            }

            if (countOfValidFields == requiredValidFields)
            {
                formDataVaild = true;
                return tempPerson;
            }
            else
            {
                MessageBox.Show("Form data is not valid");
                PersonNameTextBox.Focus();
            }

            return tempPerson;

        }

    }
}
