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
        #region Handler Variables
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

        #region Constructors
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
        
        #region Loaded
        
        //works on page loaded
        
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //confirm the data has been recived
            MessageBox.Show("Person data recived for" + person.PersonName);

        }
        #endregion

        #region Navigation Buttons
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
            var pageSummary = new PageSummary(summary);
            this.NavigationService.Navigate(pageSummary);
        }
        #endregion

        #region Data Methods

        private List<string> Machines()
        {
            return Lists.Machines();
        }

        private List<string> Levels()
        {
            return Lists.Levels();
        }

        private double FractionOfHour(int minutes)
        {
            //in order to reutn double
            //int minutes must be changed into a double
            return (double)minutes / 60;
        }
        #endregion

        #region Display String Methods
        //whole list of activities in one string
        private string MakeWholeDisplayString(List<string> displayList)
        {
            var sb = new StringBuilder();
            sb.Append("Machine").Append("\t").Append("\t").Append("Minutes").Append("\t").AppendLine("Used");

            foreach (var line in displayList)
            {
                sb.Append(line);

            }
            return sb.ToString();
        }

        private string MakeSingleDisplayString(Activity activity)
        {
            var tempString = string.Empty;
            var sb = new StringBuilder();
            var usedString = Convert.ToInt32(activity.Used).ToString();

            if (activity.MachineName.Length >= 12)
            {
                sb.Append(activity.MachineName).Append("\t").Append(activity.Duration.ToString()).Append("\t").AppendLine(usedString);
            }
            else
            {
                sb.Append(activity.MachineName).Append("\t").Append("\t").Append(activity.Duration.ToString()).Append("\t").AppendLine(usedString);
            }

            return sb.ToString();
        }

        #endregion

        #region HarvestFrom method
        private Activity HarvestForm
        {
            get
            {

                isWeighted = InclinedCheckBox.IsChecked ?? false;
                
                //Handler variables
                double durationFractionOfHour = 0;
                double usedInActivity = 0;
                float weightingFactor = 1.11F;

                //Error check the duration.
                //First, is there a value?
                //second, does value meet rules of 5 - 60 minutes?
                //Use a nested 'if' construct
                if (!string.IsNullOrEmpty(DurationTextBox.Text))
                {
                    var durationRecordedToCheck = Convert.ToInt32(DurationTextBox.Text);
                    //check it meets length rule
                    if (ActivityValidation.ActivityDurationValid(durationRecordedToCheck))
                    {
                        durationRecorded = Convert.ToInt32(DurationTextBox.Text);
                    }
                    else //for value outsdide the rule 5 - 60 minutes
                    {
                        MessageBox.Show(" The activity duration must be between 5 and 60 mminutes");
                    }
                }
                else //Outcome for empty duration text box
                {
                    MessageBox.Show("You must enter a duration for the activity");
                }

                //convert minutes to a fraction of an hour.
                durationFractionOfHour = FractionOfHour(durationRecorded);
                
                //Get the Rate for combination of Machine and Level
                usageRate = MachineDataDb.GetRate(selectedMachine, selectedLevel);
                
                //If the weighted/inlined check box true, usage is increased by 11 %
                //Else, straughtforward multiplication of Rate per Hour * Fraction of hour recorded
                if (isWeighted)
                {
                    usedInActivity = usageRate * durationFractionOfHour *weightingFactor;
                }
                else
                {
                    usedInActivity = usageRate * durationFractionOfHour;
                }
                
                //-- Add new data
                usedRunningTotal += usedInActivity;
                
                //-- Assign values to the object to be returned 
                Activity tempActivity = new Activity
                {
                    MachineName = selectedMachine,
                    Weighted = isWeighted,
                    Level = selectedLevel,
                    Duration = durationRecorded,
                    Used = usedInActivity
                };
                
                StringBuilder sb = new StringBuilder();
                
                sb.Append("Person name: ").AppendLine(summary.SessionPerson.PersonName);
                sb.Append("Person age: ").AppendLine(summary.SessionPerson.Age.ToString());
                sb.Append("Person weight: ").AppendLine(summary.SessionPerson.Weight.ToString());
                sb.AppendLine();
                sb.AppendLine(selectedMachine);
                sb.AppendLine(isWeighted.ToString());
                sb.AppendLine(selectedLevel);
                sb.AppendLine(durationRecorded.ToString());
                sb.Append("Usage rate: ").AppendLine(usageRate.ToString("#.##"));
                sb.Append("Duration fraction of hour: ").AppendLine(durationFractionOfHour.ToString("#.##"));
                sb.Append("Used ").AppendLine(usedInActivity.ToString("#.##"));

                MessageBox.Show(sb.ToString());
                
                //-- Return the Activity object constructed from the values
                //-- Harvested from the form.
                return tempActivity;
            }
        }
        #endregion

        #region Machines combo DropDown control.
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
            if (selectedMachine == "Treadmill")
            {
                InclinedCheckBoxLabel.Visibility = Visibility.Visible;
                InclinedCheckBox.Visibility = Visibility.Visible;
            }
            else
            {
                InclinedCheckBoxLabel.Visibility = Visibility.Hidden;
                InclinedCheckBox.Visibility = Visibility.Hidden;
            }
        }
        #endregion

        #region Levels Combo Dropdown control
        private void LevelsCombo_Loaded(object sender, RoutedEventArgs e)
        {
            var combo = sender as ComboBox;
            combo.ItemsSource = Levels();
            combo.SelectedIndex = 0;
        }
        private void LevelsCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedLevelCombo = sender as ComboBox;
            selectedLevel = selectedLevelCombo.SelectedItem as string;
        }
        #endregion
        
        
        //process the data
        #region 07 Data Processing Methods
        private void AddActivityButton_Click(object sender, RoutedEventArgs e)
        {
            //Activity object to hold data
            Activity currentActivity = new Activity();

            //assign by harvesting form data
            currentActivity = HarvestForm;

            //increase the count of activities
            activitiesRecorded++;

            //Increase the totalMinutes
            totalMinutesOfExercise += currentActivity.Duration;

            //check that no more than 6 activities recorded
            if(activitiesRecorded <= 6)
            {
                //add the current activity to the summary object
                recordedActivities.Add(currentActivity);

                //show that activity is added
                CountOfActivitesTextBlock.Text = activitiesRecorded.ToString();

                //reset text box
                DurationTextBox.Text = "";

                //Manage display string
                var listString = MakeSingleDisplayString(currentActivity);
                activitiesToDisplay.Add(listString);

                //refresh and display list of activities
                ActivityListTextBlock.Text = MakeWholeDisplayString(activitiesToDisplay);
            }
            else
            {
                MessageBox.Show("The maximum number of activities is 6");
            }
        }

        #endregion
       

    }
}
