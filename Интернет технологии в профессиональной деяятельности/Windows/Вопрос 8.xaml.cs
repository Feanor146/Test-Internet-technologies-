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
    public partial class Вопрос_8 : Window
    {
        public Вопрос_8()
        {
            InitializeComponent();
            Okna.Вопрос8 = this;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Okna.Вопрос7.Visibility = Visibility.Visible;
            Hide();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Okna.Вопрос9 == null)
            {
                Okna.Вопрос9 = new Вопрос_9();
                Okna.Вопрос9.Show();
                Hide();
            }
            else
            {
                Okna.Вопрос9.Visibility = Visibility.Visible;
                Hide();
            }
        }
    }
}
