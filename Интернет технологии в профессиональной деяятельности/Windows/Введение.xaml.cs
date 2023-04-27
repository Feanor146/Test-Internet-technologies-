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
    public partial class Введение : Window
    {
        public Введение()
        {
            InitializeComponent();
            Okna.Введение = this;            
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (FIO.Text=="" || GroupNumber.Text == "")
            {
                MessageBox.Show("Не введено ФИО или номер группы!","Внимание!", MessageBoxButton.OK ,MessageBoxImage.Warning);
                return;
            }
            if (Okna.Вопрос1==null)
            {
                Okna.Вопрос1 = new Вопрос_1();
                Okna.Вопрос1.Show();
                Visibility = Visibility.Hidden;
            }
            else
            {
                Okna.Вопрос1.Show();
                Visibility = Visibility.Hidden;
            }
        }
    }
}
