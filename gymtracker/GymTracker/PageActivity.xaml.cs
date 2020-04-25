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

/*
     Title: PageActivity.xaml.cs
     Author: Keaton Sutcliffe
     Date:25/04/2020
     Purpose: Process Activites
*/


namespace GymTracker
{
    /// <summary>
    /// Interaction logic for PageActivity.xaml
    /// </summary>
    public partial class PageActivity : Page
    {
        #region 01 Handler Variables
        internal static string selectedMachine = "";
        internal static string selectedLevel = "";
        internal bool isWeighted = false;
        internal int durationRecorded = 0;
        internal int usageRate = 0;
        internal double usedRunningTotal = 0;
        internal int totalMinutesOfExercise = 0;
        //holding data for display
        internal List<Activity> recordedActivities = new List<Activity>();
        internal List<string> activitiesToDisplay = new List<string>();

        //holding the person data after passed
        internal static Person person = new Person();

        //holding the activity data
        internal static Summary summary = new Summary();

        //tracking amount of activities
        internal static int activitiesRecorded = 0;
        #endregion

        #region 02 03 Constructors
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
        //another constructor for when loaded without a person available
        public PageActivity()
        {
            InitializeComponent();

            //hide the inclined contorls 
            InclinedCheckBoxLabel.Visibility = Visibility.Hidden;
            InclinedCheckBox.Visibility = Visibility.Hidden;

            //list headers
            var headers = "Machine" + "/t" + "Used" + "/t" + "used";
            activitiesToDisplay.Add(headers);
        }
        #endregion

        #region 04 Loaded
        //works on page loaded
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //confirm the data has been recived
            MessageBox.Show("Person data recived for" + person.PersonName);

        }
        #endregion

        #region 05 Navigation Buttons
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            var pagePerson = new PagePerson();
            this.NavigationService.Navigate(pagePerson);
        }
        private void PageSummaryButton_Click(object sender, RoutedEventArgs e)
        {
            //finalise the summary object
            summary.NumberOfActivities = recordedActivities.Count;
            summary.MinutesOfExercise = totalMinutesOfExercise;
            summary.TotalUsed = (int)usedRunningTotal;
            var pageSimmary = new PageSummary(summary);
            this.NavigationService.Navigate(pageSummary);
        }
        #endregion

        #region 05 Machines combo handler methods.
        //load data
        private void MachinesCombo_Loaded(object sender, RoutedEventArgs e)
        {
            var combo = sender as ComboBox;
            combo.ItemsSource = Machines();
            combo.SelectedIndex = 0;
        }

        private void MachinesCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedMachineCombo = sender as ComboBox;
            selectedMachine = selectedMachineCombo.SelectedItem as string;
            //contorl the visibility of the checkbox contorl label and checkbox
            if(selectedMachine == "Treadmill")
            {
                InclinedCheckBoxLabel.Visibility = Visibility.Visible;
                InclinedCheckBox.Visibility = Visibility.Visible;
            }
            else
            {
                InclinedCheckBoxLabel.Visibility = Visibility.Hidden;
                InclinedCheckBox.Visibility = Visibility.Hidden;
            }
            #endregion

            #region 06 
        }
    }
}
