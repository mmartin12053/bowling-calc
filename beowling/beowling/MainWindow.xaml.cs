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

namespace beowling
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        double num1 = 0;
        double num2 = 0;
        double num3 = 0;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void calc_button_Click(object sender, RoutedEventArgs e)
        {
            Double.TryParse(box_1.Text, out num1);
            Double.TryParse(box_2.Text, out num2);
            Double.TryParse(box_3.Text, out num3);

            double answer = ((num1 + num2 + num3) / 3);

            double score = (num1 + num2 + num3);


            double hand = ((200-answer)*0.8);

            answerBox.Text = answer.ToString();
            answerBox_Copy.Text = hand.ToString();
            answerBox_Copy1.Text = score.ToString();
        }
    }
}
