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
using System.Windows.Shapes;
namespace Интернет_технологии_в_профессиональной_деяятельности.Windows
{
    public partial class Вопрос_10 : Window
    {
        public Вопрос_10()
        {
            InitializeComponent();
            Okna.Вопрос10 = this;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Okna.Вопрос9.Visibility = Visibility.Visible;
            Hide();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {            
            Okna.Итог = new Итог();
            Okna.Итог.Show();
            Hide();          
        }
    }
}
