using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Interaction logic for signup.xaml
    /// </summary>
    public partial class signup : Page
    {
        facebookEntities db = new facebookEntities();
        public signup()
        {
            InitializeComponent();
        }

        private void sign_in(object sender, RoutedEventArgs e)
        {
            signin signin = new signin();
            NavigationService.Navigate(signin);
        }

        private void sign_up(object sender, RoutedEventArgs e)
        {
            Regex regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*\W).+$");
            try
            {
                if (regex.IsMatch(password_t.Text))
                {
                    if (int.Parse(age_t.Text) >= 18 && int.Parse(age_t.Text) <= 60)
                    {
                        if (phone_t.Text.Length == 11)
                        {
                            if (male.IsChecked == true)
                            {

                                user user = new user();
                                user.username = name_T.Text;
                                user.password = password_t.Text;
                                user.age = int.Parse(age_t.Text);
                                user.gender = "male";
                                user.phone_number = phone_t.Text;
                                user.city = combo.Text;
                                db.users.Add(user);
                                db.SaveChanges();
                                signin signin = new signin();
                                NavigationService.Navigate(signin);

                            }
                            else if (female.IsChecked == true)
                            {

                                user user = new user();
                                user.username = name_T.Text;
                                user.password = password_t.Text;
                                user.age = int.Parse(age_t.Text);
                                user.gender = "female";
                                user.phone_number = phone_t.Text;
                                user.city = combo.Text;
                                db.users.Add(user);
                                db.SaveChanges();
                                signin signin = new signin();
                                NavigationService.Navigate(signin);

                            }
                            else
                            {
                                MessageBox.Show("select your gender");
                            }
                        }
                        else
                        {
                            MessageBox.Show("phone number must be 11 number");
                        }
                    }
                    else
                    {
                        MessageBox.Show("age must be between 18 and 60");
                    }
                }
                else
                {
                    MessageBox.Show("your password must contain special charcters and digits and letters and capital letters");
                }
            }
            catch
            {
                MessageBox.Show("invalid input or this phone number already exist");
            }
                
                
            

        }
    }
}
