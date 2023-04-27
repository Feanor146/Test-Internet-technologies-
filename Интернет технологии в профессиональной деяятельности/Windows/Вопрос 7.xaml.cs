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
    public partial class Вопрос_7 : Window
    {
        public Вопрос_7()
        {
            InitializeComponent();
            Okna.Вопрос7 = this;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Okna.Вопрос6.Visibility = Visibility.Visible;
            Hide();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Okna.Вопрос8 == null)
            {
                Okna.Вопрос8 = new Вопрос_8();
                Okna.Вопрос8.Show();
                Hide();
            }
            else
            {
                Okna.Вопрос8.Visibility = Visibility.Visible;
                Hide();
            }
        }
    }
}
