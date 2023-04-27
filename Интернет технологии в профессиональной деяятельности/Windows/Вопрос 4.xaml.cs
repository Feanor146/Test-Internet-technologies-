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
    public partial class Вопрос_4 : Window
    {
        public Вопрос_4()
        {
            InitializeComponent();
            Okna.Вопрос4 = this;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Okna.Вопрос3.Visibility = Visibility.Visible;
            Hide();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Okna.Вопрос5 == null)
            {
                Okna.Вопрос5 = new Вопрос_5();
                Okna.Вопрос5.Show();
                Hide();
            }
            else
            {
                Okna.Вопрос5.Visibility = Visibility.Visible;
                Hide();
            }
        }
    }
}
