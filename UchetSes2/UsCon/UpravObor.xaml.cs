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

namespace UchetSes2.UsCon
{
    /// <summary>
    /// Логика взаимодействия для UpravObor.xaml
    /// </summary>
    public partial class UpravObor : UserControl
    {
        public UpravObor()
        {
            InitializeComponent();
            Obor1.ItemsSource = Entities1.GetContext().AbonObor.ToList();
            Obor2.ItemsSource = Entities1.GetContext().SetDostupa.ToList();
            Obor3.ItemsSource = Entities1.GetContext().Magistrali.ToList();
        }
    }
}
