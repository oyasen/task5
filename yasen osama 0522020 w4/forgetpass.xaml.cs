using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for forgetpass.xaml
    /// </summary>
    public partial class forgetpass : Page
    {
        facebookEntities db = new facebookEntities();
        public forgetpass()
        {
            InitializeComponent();
        }

        private void update_button(object sender, RoutedEventArgs e)
        {
           
                Regex regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*\W).+$");
                
                if (regex.IsMatch(npass_t.Text))
                {
                    if (npass_t.Text == cpass_t.Text)
                    {
                        user user = new user();
                        user = db.users.First(x => x.phone_number == phone_t.Text); ;
                        user user1 = user;
                        user1.password = npass_t.Text;
                        db.users.AddOrUpdate(user1);
                        db.SaveChanges();
                        signin signin = new signin();
                        NavigationService.Navigate(signin);
                    }
                    else
                    {
                        MessageBox.Show("password doen't match");
                    }
                }
                else
                {
                    MessageBox.Show("password must be strong");
                }
            



        }
    }
}
