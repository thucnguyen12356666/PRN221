using Candidate_BusinessObjects.Entities;
using Candidate_Services;
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

namespace CandidateManagement_NguyenMinhThuc
{
    /// <summary>
    /// Interaction logic for JobPostingWindow.xaml
    /// </summary>
    public partial class JobPostingWindow : Window
    {
        private IJobPostingService jobPostingService;
        public JobPostingWindow()
        {
            InitializeComponent();
            jobPostingService = new JobPostingService();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            JobPosting newJob = new JobPosting
            {
                PostingId = txtPostingID.Text,
                JobPostingTitle = txtTitle.Text,
                Description = txtDescription.Text,
                PostedDate = dpPostDate.SelectedDate.HasValue ? dpPostDate.SelectedDate.Value : (DateTime?)null

            };

            bool isSuccess = jobPostingService.AddJobPosting(newJob);

            if (isSuccess)
            {
                MessageBox.Show("Job posting added successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Failed to add job posting!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
