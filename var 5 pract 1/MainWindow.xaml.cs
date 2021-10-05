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
using Lib_5;

namespace var_5_pract_1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_Generate(object sender, RoutedEventArgs e)
        {
            int k;
            try
            {
                k = Convert.ToInt32(KTextBox.Text);
                int kolvo;
                int sumGeneret;
                resh.GeneretToSumm(-1, 3, k, out string mas, out kolvo, out sumGeneret);
                numbers.Text = mas;
                SummTextBox.Text = sumGeneret.ToString();
                KolvoTextBox.Text = kolvo.ToString();
            }
            catch { MessageBox.Show(" а ну заполни поле", "@приказ@"); }
        }
        private void Button_Click_exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Button_Click_info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Косоуров И. Н.\nвариант 5 практическая 1\n\nВычислить сумму целых случайных чисел, распределенных в диапазоне от - 7 до 3,\nпока эта сумма не превышает некоторого числа K.Вывести на экран\nсгенерированные числа, значение суммы, и количество сгенерированных чисел.","информация о программе");
        }
        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int val;
            if (!Int32.TryParse(e.Text, out val) && e.Text != "-")
            {
                e.Handled = true; // отклоняем ввод
            }
        }
    }   
}
