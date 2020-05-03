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
    /// Interaction logic for PageSummary.xaml
    /// </summary>
    public partial class PageSummary : Page
    {
        Summary summary = new Summary();

        public PageSummary(Summary summaryPassed)
        {
            InitializeComponent();

            summary = summaryPassed;

            string person = summary.SessionPerson.PersonName;
            string numberOfActivities = summary.NumberOfActivities.ToString();
            string minutesOfExercise = summary.MinutesOfExercise.ToString();
            string totalUsed = summary.TotalUsed.ToString();

            //fill in the infromation contorls.
            PersonTextBlock.Text = person;

            NumberActivitesTextBlock.Text = "Number Of Activities: " + numberOfActivities;

            MinutesExerciseTextBlock.Text = "Minutes of Exercise: " + minutesOfExercise;

            TotalUsedTextBlock.Text = totalUsed;

        }

        private void SummaryPageBackButton_Click(object sender, RoutedEventArgs e)
        {
            var pageActivity = new PageActivity();
            this.NavigationService.Navigate(pageActivity);
        }

        private void SummaryPageExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
