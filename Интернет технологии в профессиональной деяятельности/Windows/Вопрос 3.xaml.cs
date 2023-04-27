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
    public partial class Вопрос_3 : Window
    {
        public Вопрос_3()
        {
            InitializeComponent();
            Okna.Вопрос3 = this;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Okna.Вопрос2.Visibility = Visibility.Visible;
            Hide();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Okna.Вопрос4 == null)
            {
                Okna.Вопрос4 = new Вопрос_4();
                Okna.Вопрос4.Show();
                Hide();
            }
            else
            {
                Okna.Вопрос4.Visibility = Visibility.Visible;
                Hide();
            }
        }
    }
}
