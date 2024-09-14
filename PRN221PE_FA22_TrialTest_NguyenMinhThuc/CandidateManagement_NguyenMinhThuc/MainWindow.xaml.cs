using Candidate_BusinessObjects.Entities;
using Candidate_Serivces;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CandidateManagement_NguyenMinhThuc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IHRAccountService iHRAccountService;
        public MainWindow()
        {
            InitializeComponent();
            iHRAccountService = new HRAccountService();

        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Password))
            {
                MessageBox.Show("Please enter email and password!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            Hraccount hraccount = iHRAccountService.GetHraccount(txtUsername.Text);

            if (hraccount == null)
            {
                MessageBox.Show("Login failed! Please check your email or password.", "Login Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (hraccount.MemberRole != 1)
            {
                MessageBox.Show("You do not have permission to access this function!", "Access Denied", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            this.Hide();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult answer = MessageBox.Show("Do you want to exit the app?", "Exit App!", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (answer == MessageBoxResult.Yes)
                Application.Current.Shutdown();
        }
    }
    }
