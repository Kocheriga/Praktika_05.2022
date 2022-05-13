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
using System.Timers;
using System.Windows.Threading;
using System.Data.SqlClient;
using System.Data;
using System.Threading;

namespace Uchet
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    { 
        public DispatcherTimer timer;
        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            
        }
        public char[] randomWord = new char[8];
        bool stop = false;
        public string code;
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i < 8; i++)
            {
                randomWord[i] = (char)random.Next(48, 123);
            }
            code = new string(randomWord);
            timer.Start();
            timer.Tick += new EventHandler(timer_Tick);
            new Thread(()=>MessageBox.Show(code, $"У вас 10 секунд")).Start();    
            if (stop == true)
            {
                this.Close();
            }
        }

        long ticks = 0;
       
        private void timer_Tick(object sender, EventArgs e)
        {
            ticks++;
           
            if (ticks >= 3)
            {
                timer.Stop();
                stop = true;
            }
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            txbCode.Text = "";
            txbLogin.Text = "";
            txbPassword.Password = "";
        }
        private string connstring;
        private SqlConnection conn;
        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {
            try 
            {
                connstring = @"data source=(LocalDB)\MSSQLLocalDB;attachdbfilename=|DataDirectory|\Uchet.mdf;integrated security=True";
                conn = new SqlConnection(connstring);

                SqlCommand cmd = new SqlCommand("SELECT * FROM [User] " +
                    "WHERE Login = @login AND Password =@password");
                cmd.Connection = conn;
                conn.Open();
                cmd.Parameters.AddWithValue("@login", txbLogin.Text);
                cmd.Parameters.AddWithValue("@password", txbPassword.Password);
                SqlDataReader Dr = cmd.ExecuteReader();
                int i1 = 0;
                while (Dr.Read())
                {
                    i1++;
                }
                if (i1 == 1)
                {
                    if (txbCode.Text == code)
                    { 
                    UserWindow user = new UserWindow();
                    user.Show();
                    this.Close();
                    } 
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                }
                conn.Close();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Ошибка"); 
            }
        }
    }
}
