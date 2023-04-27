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
    public partial class Итог : Window
    {
        public Итог()
        {
            InitializeComponent();
            FIO.Content = Okna.Введение.FIO.Text;
            REZ.Content = "Ваш результат:" + Convert.ToString(rezcalc) + "/10";
            if (rezcalc < 5)
            {
                Brush brush = new SolidColorBrush(Color.FromRgb(218, 47, 29));
                REZ.Foreground = brush;
            }
            else if (rezcalc > 5 || rezcalc < 7)
            {
                Brush brush = new SolidColorBrush(Color.FromRgb(208, 116, 37));
                REZ.Foreground = brush;
            }
            else if (rezcalc > 7 || rezcalc < 9)
            {
                Brush brush = new SolidColorBrush(Color.FromRgb(169, 255, 70));
                REZ.Foreground = brush;
            }
            else if (rezcalc >= 9)
            {
                Brush brush = new SolidColorBrush(Color.FromRgb(70, 255, 90));
                REZ.Foreground = brush;
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Okna.Вопрос1 = null;
            Okna.Вопрос2 = null;
            Okna.Вопрос3 = null;
            Okna.Вопрос4 = null;
            Okna.Вопрос5 = null;
            Okna.Вопрос6 = null;
            Okna.Вопрос7 = null;
            Okna.Вопрос8 = null;
            Okna.Вопрос9 = null;
            Okna.Вопрос10 = null;
            Okna.Введение = null;
            Okna.Введение = new Введение();
            Okna.Введение.Show();
            Close();
        }
        private int rezcalc 
        { 
            get
            {
                int i = 0;
                if (Okna.Вопрос1.a.IsChecked == true)
                {
                    i++;
                }
                if (Okna.Вопрос2.b.IsChecked == true)
                {
                    i++;
                }
                if (Okna.Вопрос3.c.IsChecked == true)
                {
                    i++;
                }
                if (Okna.Вопрос4.a.IsChecked == true)
                {
                    i++;
                }
                if (Okna.Вопрос5.c.IsChecked == true)
                {
                    i++;
                }
                if (Okna.Вопрос6.b.IsChecked == true)
                {
                    i++;
                }
                if (Okna.Вопрос7.c.IsChecked == true)
                {
                    i++;
                }
                if (Okna.Вопрос8.a.IsChecked == true)
                {
                    i++;
                }
                if (Okna.Вопрос9.c.IsChecked == true)
                {
                    i++;
                }
                if (Okna.Вопрос10.b.IsChecked == true)
                {
                    i++;
                }
                return i;
            } 
        }
    }
}
