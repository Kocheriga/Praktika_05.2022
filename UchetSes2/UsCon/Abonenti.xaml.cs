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
    /// Логика взаимодействия для Abonenti.xaml
    /// </summary>
    public partial class Abonenti : UserControl
    {
        public Abonenti()
        {
            InitializeComponent();
            //abonenti.ItemsSource = Entities1.GetContext().Abonenti.ToList();
        }
    }
}
