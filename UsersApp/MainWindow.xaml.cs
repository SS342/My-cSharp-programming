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

namespace UsersApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ApplicationContext db;

        public MainWindow()
        {
            InitializeComponent();

            db = new ApplicationContext();
        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string password1= passwordBox_1.Password.Trim();
            string password2 = passwordBox_2.Password.Trim();
            string email = textBoxEmail.Text.Trim().ToLower();

            int reg_error = 3;

            if(login.Length < 5)
            {
                textBoxLogin.ToolTip = "Должно быть больше 5 символов";
                textBoxLogin.Background = Brushes.Red;
            }
            else
            {
                textBoxLogin.Background = Brushes.White;
                reg_error -= 1;
            }

            if(password1 != password2 || password1.Length < 5 || password2.Length < 5)
            {
                passwordBox_1.ToolTip = "Пароли не совпадают или слишком короткие!";
                passwordBox_1.Background = Brushes.Red;
                passwordBox_2.ToolTip = "Пароли не совпадают или слишком короткие!";
                passwordBox_2.Background = Brushes.Red;
            }
            else
            {
                passwordBox_1.Background = Brushes.White;
                passwordBox_2.Background = Brushes.White;
                reg_error -= 1;
            }

            if(email.Length < 4)
            {
                textBoxEmail.ToolTip = "Некоректный Email";
                textBoxEmail.Background = Brushes.Red;
            }
            else{
                textBoxEmail.Background = Brushes.White;
                reg_error -= 1;
            }

            if(reg_error == 0)
            {
                textBoxEmail.ToolTip = "";
                textBoxLogin.ToolTip = "";

                passwordBox_1.ToolTip = "";
                passwordBox_2.ToolTip = "";

                textBoxEmail.Background = Brushes.Transparent;
                textBoxLogin.Background = Brushes.Transparent;

                passwordBox_1.Background = Brushes.Transparent;
                passwordBox_2.Background = Brushes.Transparent;

                MessageBox.Show("Вы зарегестрированны!");

                User user = new User(login, email, password2);

                db.Users.Add(user);
                db.SaveChanges();
            }
        }
    }
}
