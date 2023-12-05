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

namespace facebook
{
    /// <summary>
    /// Interaction logic for profile.xaml
    /// </summary>
    public partial class profile : Page
    {
        public profile(user user)
        {
            InitializeComponent();
            profile_name.Content = user.username + " profile";
            user_t.Text = user.username;
            pass_t.Password = user.password;
            age_t.Text = user.age.ToString();
            gender_t.Text = user.gender;
            phone_t.Text = user.phone_number;
            city_t.Text = user.city;
        }

        private void logout_Click(object sender, RoutedEventArgs e)
        {
            signin signin = new signin();
            NavigationService.Navigate(signin);
        }
    }
}
