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
using System.Data.SqlClient;

namespace UchetSes2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Content_control.Content = new UchetSes2.UsCon.Abonenti();
            sotrudnik.ItemsSource = Entities1.GetContext().Sotrudnik.ToList();
            string connstring = @"data source=(LocalDB)\MSSQLLocalDB;attachdbfilename=|DataDirectory|\Uchet.Ses2.mdf;integrated security=True";
            conn = new SqlConnection(connstring);
        }
      
        private SqlConnection conn;
        private void abonents_btn_Click(object sender, RoutedEventArgs e)
        {
            Content_control.Content = new UchetSes2.UsCon.Abonenti();
            nameOfPage.Text = "Абонента ТНС";
        }

        private void upravObor_btn_Click(object sender, RoutedEventArgs e)
        {
            Content_control.Content = new UchetSes2.UsCon.UpravObor();
            nameOfPage.Text = "Управление оборудованием";
        }

        private void activ_btn_Click(object sender, RoutedEventArgs e)
        {
            Content_control.Content = new UchetSes2.UsCon.Activi();
            nameOfPage.Text = "Активы";
        }

        private void billing_btn_Click(object sender, RoutedEventArgs e)
        {
            Content_control.Content = new UchetSes2.UsCon.Billing();
            nameOfPage.Text = "Биллинг";
        }

        private void userSup_btn_Click(object sender, RoutedEventArgs e)
        {
            Content_control.Content = new UchetSes2.UsCon.UserSup();
            nameOfPage.Text = "Поддержка пользователей";
        }

        private void crm_btn_Click(object sender, RoutedEventArgs e)
        {
            Content_control.Content = new UchetSes2.UsCon.CRM();
            nameOfPage.Text = "CRM";
        }
        
        
        private void sotrudnik_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                
                SqlCommand cmd = new SqlCommand("SELECT * FROM Sotrudnik WHERE ФИО=@user AND Должность='Руководитель отдела по работе с клиентами'", conn);
                cmd.Connection = conn;
                conn.Open();
                cmd.Parameters.AddWithValue("@user", sotrudnik.SelectedValue.ToString());
                SqlDataReader Dr = cmd.ExecuteReader();
                int i1 = 0;
                while (Dr.Read())
                {
                    i1++;
                }
                if (i1 == 1)
                {
                    activ_btn.Visibility = 0;
                    upravObor_btn.Visibility = 0;
                    userSup_btn.Visibility = 0;
                }
                conn.Close();


                SqlCommand cmd1 = new SqlCommand("SELECT * FROM Sotrudnik WHERE ФИО=@user AND Должность='Менеджер по работе с клиентами'", conn);
                cmd1.Connection = conn;
                conn.Open();
                cmd1.Parameters.AddWithValue("@user", sotrudnik.SelectedValue.ToString());
                SqlDataReader Dr1 = cmd1.ExecuteReader();
                int i2 = 0;
                while (Dr1.Read())
                {
                    i2++;
                }
                if (i2 == 1)
                {
                    activ_btn.Visibility = 0;
                    upravObor_btn.Visibility = 0;
                    userSup_btn.Visibility = 0;
                    billing_btn.Visibility = 0;

                }
                conn.Close();


                SqlCommand cmd2 = new SqlCommand("SELECT * FROM Sotrudnik WHERE ФИО=@user AND Должность='Руководитель отдела технической поддержки'", conn);
                cmd2.Connection = conn;
                conn.Open();
                cmd2.Parameters.AddWithValue("@user", sotrudnik.SelectedValue.ToString());
                SqlDataReader Dr2 = cmd2.ExecuteReader();
                int i3 = 0;
                while (Dr2.Read())
                {
                    i3++;
                }
                if (i3 == 1)
                {
                    activ_btn.Visibility = 0;
                    billing_btn.Visibility = 0;

                }
                conn.Close();

                SqlCommand cmd3 = new SqlCommand("SELECT * FROM Sotrudnik WHERE ФИО=@user AND Должность='Специалист ТП (выездной инженер)'", conn);
                cmd3.Connection = conn;
                conn.Open();
                cmd3.Parameters.AddWithValue("@user", sotrudnik.SelectedValue.ToString());
                SqlDataReader Dr3 = cmd3.ExecuteReader();
                int i4 = 0;
                while (Dr3.Read())
                {
                    i4++;
                }
                if (i4 == 1)
                {
                    activ_btn.Visibility = 0;
                    billing_btn.Visibility = 0;

                }
                conn.Close();


                SqlCommand cmd4 = new SqlCommand("SELECT * FROM Sotrudnik WHERE ФИО=@user AND Должность='Бухгалтер'", conn);
                cmd4.Connection = conn;
                conn.Open();
                cmd4.Parameters.AddWithValue("@user", sotrudnik.SelectedValue.ToString());
                SqlDataReader Dr4 = cmd4.ExecuteReader();
                int i5 = 0;
                while (Dr4.Read())
                {
                    i5++;
                }
                if (i5 == 1)
                {
                     upravObor_btn.Visibility = 0;
                    userSup_btn.Visibility = 0;
                    crm_btn.Visibility = 0;
                    

                }
                conn.Close();

                SqlCommand cmd5 = new SqlCommand("SELECT * FROM Sotrudnik WHERE ФИО=@user AND Должность='Директор по развитию'", conn);
                cmd5.Connection = conn;
                conn.Open();
                cmd5.Parameters.AddWithValue("@user", sotrudnik.SelectedValue.ToString());
                SqlDataReader Dr5 = cmd5.ExecuteReader();
                int i6 = 0;
                while (Dr5.Read())
                {
                    i6++;
                }
                if (i6 == 1)
                {
             

                }
                conn.Close();

                SqlCommand cmd6 = new SqlCommand("SELECT * FROM Sotrudnik WHERE ФИО=@user AND Должность='Технический департамент'", conn);
                cmd6.Connection = conn;
                conn.Open();
                cmd6.Parameters.AddWithValue("@user", sotrudnik.SelectedValue.ToString());
                SqlDataReader Dr6 = cmd6.ExecuteReader();
                int i7 = 0;
                while (Dr6.Read())
                {
                    i7++;
                }
                if (i7 == 1)
                {

                    userSup_btn.Visibility = 0;
                    billing_btn.Visibility = 0;
                }
                conn.Close();
            }
            catch
            {

            }
        }
    }
}
