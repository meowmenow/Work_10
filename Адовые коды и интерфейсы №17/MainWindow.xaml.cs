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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Адовые_коды_и_интерфейсы__17
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double x1, x2, z;
            bool f1, f2;
            f1 = double.TryParse(zn1.Text, out x1);
            f2 = double.TryParse(zn2.Text, out x2);
            if (f1 == true && f2 == true)
            {
                if (x1 < 0 && x2 < 0) //Проверка на отрицательность
                {
                    z = Math.Sqrt(x1 * x2); //Находим геометрический корень
                    rez.Text = Convert.ToString(z);
                }
                else
                {
                    MessageBox.Show("Больше нуля не принимаю");
                }
            }
            else MessageBox.Show("Я не алфавит, а калькулятор"); //Запрет на ввод буквенных значений
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            zn1.Clear();
            zn2.Clear();
            rez.Clear();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            int x1, z;
            bool f1;
            f1 = Int32.TryParse(stanovis.Text, out x1);
            if (f1 == true)
            {
                if (99<x1 && x1<1000)  //Проверка на трёхзначность
                {
                    z = (x1 % 100) * 10 + x1 / 100; //Процесс перестановки
                    rezik.Text = Convert.ToString(z);
                }
                else MessageBox.Show("Число длиннее трёх значений");

            }
            else MessageBox.Show("Я не алфавит, а калькулятор");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ИСП-23, Бирюков Георгий, Найти среднегеометрическое двух неотрицательных чисел");
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ИСП-23, Бирюков Георгий, Вывести трёхзначное число при перестановке цифр");
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            rezik.Clear();
            stanovis.Clear();
        }

    }
}
