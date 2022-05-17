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
        }

        private void abonents_btn_Click(object sender, RoutedEventArgs e)
        {
            Content_control.Content = new UchetSes2.UsCon.Abonenti();
        }

        private void upravObor_btn_Click(object sender, RoutedEventArgs e)
        {
            Content_control.Content = new UchetSes2.UsCon.UpravObor();
        }

        private void activ_btn_Click(object sender, RoutedEventArgs e)
        {
            Content_control.Content = new UchetSes2.UsCon.Activi();
        }

        private void billing_btn_Click(object sender, RoutedEventArgs e)
        {
            Content_control.Content = new UchetSes2.UsCon.Billing();
        }

        private void userSup_btn_Click(object sender, RoutedEventArgs e)
        {
            Content_control.Content = new UchetSes2.UsCon.UserSup();
        }

        private void crm_btn_Click(object sender, RoutedEventArgs e)
        {
            Content_control.Content = new UchetSes2.UsCon.CRM();
        }
    }
}
