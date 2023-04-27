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
    public partial class Вопрос_9 : Window
    {
        public Вопрос_9()
        {
            InitializeComponent();
            Okna.Вопрос9 = this;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Okna.Вопрос8.Visibility = Visibility.Visible;
            Hide();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Okna.Вопрос10 == null)
            {
                Okna.Вопрос10 = new Вопрос_10();
                Okna.Вопрос10.Show();
                Hide();
            }
            else
            {
                Okna.Вопрос10.Visibility = Visibility.Visible;
                Hide();
            }
        }
    }
}
