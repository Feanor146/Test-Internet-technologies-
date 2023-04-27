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
    public partial class Вопрос_6 : Window
    {
        public Вопрос_6()
        {
            InitializeComponent();
            Okna.Вопрос6 = this;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Okna.Вопрос5.Visibility = Visibility.Visible;
            Hide();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Okna.Вопрос7 == null)
            {
                Okna.Вопрос7 = new Вопрос_7();
                Okna.Вопрос7.Show();
                Hide();
            }
            else
            {
                Okna.Вопрос7.Visibility = Visibility.Visible;
                Hide();
            }
        }
    }
}
