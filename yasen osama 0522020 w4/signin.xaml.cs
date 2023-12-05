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
    /// Interaction logic for signin.xaml
    /// </summary>
    public partial class signin : Page
    {
        facebookEntities db = new facebookEntities();
        public signin()
        {
            InitializeComponent();
        }

        private void sign_up_Click(object sender, RoutedEventArgs e)
        {
            signup signup = new signup();
            NavigationService.Navigate(signup);
        }

        private void forget_pass_Click(object sender, RoutedEventArgs e)
        {
            forgetpass forgetpass = new forgetpass();
            NavigationService.Navigate(forgetpass);
        }

        private void sign_in_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                user user = db.users.First(x=> x.username == user_t.Text && x.password == password_t.Text);
                profile profile = new profile(user);
                NavigationService.Navigate(profile);
            }
            catch
            {
                MessageBox.Show("wrong username or password");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            admin admin = new admin();
            NavigationService.Navigate(admin);
        }
    }
}
