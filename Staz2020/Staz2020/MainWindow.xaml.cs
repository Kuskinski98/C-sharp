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

namespace Staz2020
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private long num1 = 0;
        private long num2 = 0;
        private string operation = "";

        public long Num1
        {
            get { return num1; }
            set { num1 = value; }
        }

        public long Num2
        {
            get { return num2; }
            set { num2 = value; }
        }

        public string Operation
        {
            get { return operation; }
            set { operation = value; }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (Operation == "")
            {
                Num1 = (Num1 * 10) + 1;
                txtResult.Text = Num1.ToString();
            }
            else
            {
                Num2 = (Num2 * 10) + 1;
                txtResult.Text = Num2.ToString();
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (Operation == "")
            {
                Num1 = (Num1 * 10) + 2;
                txtResult.Text = Num1.ToString();
            }
            else
            {
                Num2 = (Num2 * 10) + 2;
                txtResult.Text = Num2.ToString();
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (Operation == "")
            {
                Num1 = (Num1 * 10) + 3;
                txtResult.Text = Num1.ToString();
            }
            else
            {
                Num2 = (Num2 * 10) + 3;
                txtResult.Text = Num2.ToString();
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (Operation == "")
            {
                Num1 = (Num1 * 10) + 4;
                txtResult.Text = Num1.ToString();
            }
            else
            {
                Num2 = (Num2 * 10) + 4;
                txtResult.Text = Num2.ToString();
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (Operation == "")
            {
                Num1 = (Num1 * 10) + 5;
                txtResult.Text = Num1.ToString();
            }
            else
            {
                Num2 = (Num2 * 10) + 5;
                txtResult.Text = Num2.ToString();
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (Operation == "")
            {
                Num1 = (Num1 * 10) + 6;
                txtResult.Text = Num1.ToString();
            }
            else
            {
                Num2 = (Num2 * 10) + 6;
                txtResult.Text = Num2.ToString();
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (Operation == "")
            {
                Num1 = (Num1 * 10) + 7;
                txtResult.Text = Num1.ToString();
            }
            else
            {
                Num2 = (Num2 * 10) + 7;
                txtResult.Text = Num2.ToString();
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (Operation == "")
            {
                Num1 = (Num1 * 10) + 8;
                txtResult.Text = Num1.ToString();
            }
            else
            {
                Num2 = (Num2 * 10) + 8;
                txtResult.Text = Num2.ToString();
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (Operation == "")
            {
                Num1 = (Num1 * 10) + 9;
                txtResult.Text = Num1.ToString();
            }
            else
            {
                Num2 = (Num2 * 10) + 9;
                txtResult.Text = Num2.ToString();
            }
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (Operation == "")
            {
                Num1 = (Num1 * 10);
                txtResult.Text = Num1.ToString();
            }
            else
            {
                Num2 = (Num2 * 10);
                txtResult.Text = Num2.ToString();
            }
        }

        private void btnSum_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            txtResult.Text = "0";
        }

        private void btnSub_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            txtResult.Text = "0";
        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            txtResult.Text = "0";
        }

        private void btnMult_Click(object sender, RoutedEventArgs e)
        { 
            operation = "*";
            txtResult.Text = "0";
        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "+":
                    txtResult.Text = (Num1 + Num2).ToString();
                    break;
                case "-":
                    txtResult.Text = (Num1 - Num2).ToString();
                    break;
                case "/":
                    txtResult.Text = (Num1 / Num2).ToString();
                    break;
                case "*":
                    txtResult.Text = (Num1 * Num2).ToString();
                    break;
            }
        }

        private void btnClearEntry_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                Num1 = 0;
                
            }
            else
            {
                Num2 = 0;
                
            }
            txtResult.Text = "0";
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            Num1 = 0;
            Num2 = 0;
            Operation = "";
            txtResult.Text = "0";
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (Operation == "")
            {
                Num1 = (Num1 / 10);
                txtResult.Text = Num1.ToString();
            }
            else
            {
                Num2 = (Num2 / 10);
                txtResult.Text = Num2.ToString();
            }
        }

        private void btnNegative_Click(object sender, RoutedEventArgs e)
        {
            if (Operation == "")
            {
                Num1 *= -1;
                txtResult.Text = Num1.ToString();
            }
            else
            {
                Num2 *= -1;
                txtResult.Text = Num2.ToString();
            }
        }
    }
 }
