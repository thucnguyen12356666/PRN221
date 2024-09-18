using Candidate_BusinessObjects.Entities;
using Candidate_Repositories;
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
            string postingId = txtPostingID.Text;

            if (!string.IsNullOrEmpty(postingId))
            {
                // Tạo đối tượng JobPostingRepository (để tương tác với cơ sở dữ liệu)
                JobPostingRepository repository = new JobPostingRepository();

                // Lấy bài đăng từ cơ sở dữ liệu
                JobPosting jobPosting = repository.GetJobPosting(postingId);

                if (jobPosting != null)
                {
                    // Hiển thị thông tin bài đăng trên các điều khiển
                    txtTitle.Text = jobPosting.JobPostingTitle;
                    dpPostDate.SelectedDate = jobPosting.PostedDate;
                    txtDescription.Text = jobPosting.Description;
                }
                else
                {
                    // Nếu không tìm thấy bài đăng, hiển thị thông báo
                    MessageBox.Show("Job posting not found!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a Posting ID.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
           
            string postingId = txtPostingID.Text;

            if (!string.IsNullOrEmpty(postingId))
            {
                // Tạo đối tượng JobPostingRepository (để tương tác với cơ sở dữ liệu)
                JobPostingRepository repository = new JobPostingRepository();

                // Lấy bài đăng từ cơ sở dữ liệu
                JobPosting jobPosting = repository.GetJobPosting(postingId);

                if (jobPosting != null)
                {
                    if (!string.IsNullOrEmpty(txtTitle.Text))
                    {
                        jobPosting.JobPostingTitle = txtTitle.Text;
                    }

                    // Nếu DatePicker dpPostDate có giá trị, cập nhật ngày mới, nếu không có giá trị thì giữ nguyên
                    if (dpPostDate.SelectedDate.HasValue)
                    {
                        jobPosting.PostedDate = dpPostDate.SelectedDate.Value;
                    }

                    // Nếu textbox txtDescription không rỗng, cập nhật Description mới, nếu rỗng thì giữ nguyên
                    if (!string.IsNullOrEmpty(txtDescription.Text))
                    {
                        jobPosting.Description = txtDescription.Text;
                    }

                    // Gọi phương thức update trong repository để lưu bài đăng đã cập nhật
                    bool result = repository.UpdateJobPosting(jobPosting);

                    if (result)
                    {
                        MessageBox.Show("Job posting updated successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error updating job posting.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Job posting not found!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a Posting ID.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            // Lấy ID từ TextBox
            string postingId = txtPostingID.Text;

            if (!string.IsNullOrEmpty(postingId))
            {
                // Tạo đối tượng JobPostingRepository (để tương tác với cơ sở dữ liệu)
                JobPostingRepository repository = new JobPostingRepository();

                // Xác nhận xóa
                MessageBoxResult result = MessageBox.Show("Are you sure you want to delete this job posting?",
                                                          "Confirm Delete", MessageBoxButton.YesNo, MessageBoxImage.Warning);

                if (result == MessageBoxResult.Yes)
                {
                    // Gọi phương thức delete trong repository để xóa bài đăng
                    bool isDeleted = repository.DeleteJobPosting(postingId);

                    if (isDeleted)
                    {
                        MessageBox.Show("Job posting deleted successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

                        // Xóa thông tin hiện tại trên các điều khiển
                        txtPostingID.Text = "";
                        txtTitle.Text = "";
                        dpPostDate.SelectedDate = null;
                        txtDescription.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Error deleting job posting.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a Posting ID.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
