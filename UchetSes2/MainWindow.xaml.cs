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
            
            string connstring = @"data source=(LocalDB)\MSSQLLocalDB;attachdbfilename=|DataDirectory|\Uchet.Ses2.mdf;integrated security=True";
            conn = new SqlConnection(connstring);
            string sql = "SELECT * FROM Sotrudnik";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int index = reader.GetOrdinal("ФИО");
                name123 = reader.GetString(index);
                sotrudnik.Items.Add(name123);
            }
            reader.Close();
            conn.Close();
            
        }
        string name123;
        
        List<Sotrudnik> sotrudniki = new List<Sotrudnik>();
        
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
                switch (sotrudniki[sotrudnik.SelectedIndex].Должность)
                {
                    case "Руководитель отдела по работе с клиентами":
                        abonents_btn.Visibility = Visibility.Visible;
                        crm_btn.Visibility = Visibility.Visible;
                        billing_btn.Visibility = Visibility.Visible;
                        activ_btn.Visibility = Visibility.Hidden;
                        upravObor_btn.Visibility = Visibility.Hidden;
                        userSup_btn.Visibility = Visibility.Hidden;
                        break;
                    case "Менеджер по работе с клиентами\r\n":
                        abonents_btn.Visibility = Visibility.Visible;
                        crm_btn.Visibility = Visibility.Visible;
                        billing_btn.Visibility = Visibility.Hidden;
                        activ_btn.Visibility = Visibility.Hidden;
                        upravObor_btn.Visibility = Visibility.Hidden;
                        userSup_btn.Visibility = Visibility.Hidden;
                        break;
                    case "Руководитель отдела технической поддержки\r\n":
                        abonents_btn.Visibility = Visibility.Visible;
                        crm_btn.Visibility = Visibility.Visible;
                        billing_btn.Visibility = Visibility.Hidden;
                        activ_btn.Visibility = Visibility.Hidden;
                        upravObor_btn.Visibility = Visibility.Visible;
                        userSup_btn.Visibility = Visibility.Visible;
                        break;
                    case "Специалист ТП (выездной инженер)\r\n":
                        abonents_btn.Visibility = Visibility.Visible;
                        crm_btn.Visibility = Visibility.Visible;
                        billing_btn.Visibility = Visibility.Hidden;
                        activ_btn.Visibility = Visibility.Hidden;
                        upravObor_btn.Visibility = Visibility.Visible;
                        userSup_btn.Visibility = Visibility.Visible;
                        break;
                    case "Бухгалтер\r\n":
                        abonents_btn.Visibility = Visibility.Visible;
                        crm_btn.Visibility = Visibility.Hidden;
                        billing_btn.Visibility = Visibility.Visible;
                        activ_btn.Visibility = Visibility.Visible;
                        upravObor_btn.Visibility = Visibility.Hidden;
                        userSup_btn.Visibility = Visibility.Hidden;
                        break;
                    case "Директор по развитию\r\n":
                        abonents_btn.Visibility = Visibility.Visible;
                        crm_btn.Visibility = Visibility.Visible;
                        billing_btn.Visibility = Visibility.Visible;
                        activ_btn.Visibility = Visibility.Visible;
                        upravObor_btn.Visibility = Visibility.Visible;
                        userSup_btn.Visibility = Visibility.Visible;
                        break;
                    case "Технический департамент\r\n":
                        abonents_btn.Visibility = Visibility.Visible;
                        crm_btn.Visibility = Visibility.Visible;
                        billing_btn.Visibility = Visibility.Hidden;
                        activ_btn.Visibility = Visibility.Visible;
                        upravObor_btn.Visibility = Visibility.Visible;
                        userSup_btn.Visibility = Visibility.Hidden;
                        break;
                }
            }
            catch
            {

            }
        }
    }
}
