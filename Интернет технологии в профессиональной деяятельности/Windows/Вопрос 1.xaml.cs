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
    public partial class Вопрос_1 : Window
    {
        public Вопрос_1()
        {
            InitializeComponent();
            Okna.Вопрос1 = this;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Okna.Введение.Show();
            Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Okna.Вопрос2 == null)
            {
                Okna.Вопрос2 = new Вопрос_2();
                Okna.Вопрос2.Show();
                Visibility = Visibility.Hidden;
            }
            else
            {
                Okna.Вопрос2.Show();
                Hide();
            }
        }
    }
}
