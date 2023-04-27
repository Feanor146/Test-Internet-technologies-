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
    public partial class Вопрос_2 : Window
    {
        public Вопрос_2()
        {
            InitializeComponent();
            Okna.Вопрос2 = this;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Okna.Вопрос1.Visibility = Visibility.Visible;
            Hide();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Okna.Вопрос3 ==null)
            {
                Okna.Вопрос3 = new Вопрос_3();
                Okna.Вопрос3.Show();
                Hide();
            }
            else
            {
                Okna.Вопрос3.Visibility = Visibility.Visible;
                Hide();
            }
        }
    }
}
