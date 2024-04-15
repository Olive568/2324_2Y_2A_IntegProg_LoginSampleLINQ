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

namespace _2324_2Y_2A_IntegProg_LoginSampleLINQ
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        string use = "";
        LoginSampleDataContext _lsDC = null;
        public Window1(string username)
        {
            InitializeComponent();
            use = username;
            _lsDC = new LoginSampleDataContext(
                Properties.Settings.Default._2324_1A_LoginSampleConnectionString1);
            Welcoming.Text = "Welcome " + username;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string NewUser = newname.Text;
            var user = _lsDC.LoginUsers.FirstOrDefault(u => u.LoginID == use);
            if (user != null)
            {
                user.LoginID = NewUser;
                try
                {
                    // Save the changes to the database
                    _lsDC.SubmitChanges();
                    MessageBox.Show("Username changed successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while changing the username: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("User not found.");
            }
        }
    }
    
}
