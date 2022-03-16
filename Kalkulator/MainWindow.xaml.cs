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

namespace Kalkulator
{
  
    public partial class MainWindow : Window
    {

      

        string liczba1 = "";
        string liczba2 = "";

        int typOperacji = 0; // 1- dodawanie
                             // 2 - odejmowanie
                             // 3 - mnozenie
                             // 4 - dzielenie


        bool erasedField = false;
        public MainWindow()
        {
            InitializeComponent();
            button_comma.Content = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
        }

        
       private void addNum(string num)
        {
            //if (resultTextBox.Text.Length < 9)
            {
                var x = resultTextBox.Text;
                if (x == "0")
                {
                    resultTextBox.Text = "";
                }
                if (liczba1.Length > 0 && !erasedField)
                {
                    resultTextBox.Text = "";
                    erasedField = true;
                }

                resultTextBox.Text = resultTextBox.Text + num;
            }
        }

        private void button_AC_Click(object sender, RoutedEventArgs e)
        {
            liczba1 = "";
            liczba2 = "";
            typOperacji = 0;
            resultTextBox.Text = "0";
            erasedField = false;
            
        }

        private void button_Square_Click(object sender, RoutedEventArgs e)
        {
            liczba1 = resultTextBox.Text;
            var wSquare = 0.0;
            wSquare = Double.Parse(liczba1) * Double.Parse(liczba1) ;
            typOperacji = 0;
            liczba1 = wSquare.ToString();
            resultTextBox.Text = liczba1;
        }

        private void button_Percent_Click(object sender, RoutedEventArgs e)
        {
            liczba1 = resultTextBox.Text;
            var wPercent = 0.0;
            wPercent = Double.Parse(liczba1) / 100;
            typOperacji = 0;
            liczba1 = wPercent.ToString();
            resultTextBox.Text = liczba1;
        }

        private void button_Division_Click(object sender, RoutedEventArgs e)
        {

            
            if (liczba1.Length == 0)
                liczba1 = resultTextBox.Text;
            else
            {
                liczba2 = resultTextBox.Text;
                if (liczba2 == liczba1)
                    liczba2 = "";
            }

            if (typOperacji != 0)
            {
                Oblicz();
                resultTextBox.Text = liczba1;
            }
            typOperacji = 4;


        }

        private void button_Multiplikation_Click(object sender, RoutedEventArgs e)
        {


            if (liczba1.Length == 0)
                liczba1 = resultTextBox.Text;
            else
            {
                liczba2 = resultTextBox.Text;
                if (liczba2 == liczba1)
                    liczba2 = "";
            }
                
            if (typOperacji != 0)
            {
                Oblicz();
                resultTextBox.Text = liczba1;
            }
            typOperacji = 3;




        }
        private void button_Plus_Click(object sender, RoutedEventArgs e)
        {
            

            if (liczba1.Length == 0)
                liczba1 = resultTextBox.Text;
            else
            {
                liczba2 = resultTextBox.Text;
                if (liczba2 == liczba1)
                    liczba2 = "";
            }


            if (typOperacji != 0)
            {
                Oblicz();
                resultTextBox.Text = liczba1;
            }
            typOperacji = 1;




        }
        private void button_Minus_Click(object sender, RoutedEventArgs e)
        {

            
            if (liczba1.Length == 0)
                liczba1 = resultTextBox.Text;
            else
            {
                liczba2 = resultTextBox.Text;
                if (liczba2 == liczba1)
                    liczba2 = "";
            }

            if (typOperacji != 0)
            {

                Oblicz();
                resultTextBox.Text = liczba1;

            }
            typOperacji = 2;



        }

        private void button_PlusMinus_Click(object sender, RoutedEventArgs e)
        {

            var x = resultTextBox.Text;

            if (x.First() == '-')
            {
                var liczba = Double.Parse(x);
                liczba = Math.Abs(liczba);

                resultTextBox.Text = liczba.ToString();
            }
            else
            {
                resultTextBox.Text = "-" + x;
            }

            

        }

        private void button_comma_Click(object sender, RoutedEventArgs e)
        {
           
            for (int i = 0;i<resultTextBox.Text.Length;i++)
                {
                if (resultTextBox.Text[i] == ',')
                    return;
                }
            if(resultTextBox.Text == "0")
            {
                addNum("0,");
            }
            else
              addNum(",");

        }

        private void button0_Click(object sender, RoutedEventArgs e)
        {
            addNum("0");
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            addNum("1");
        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            addNum("2");
        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            addNum("3");
        }
        private void button4_Click(object sender, RoutedEventArgs e)
        {
            addNum("4");
        }
        private void button5_Click(object sender, RoutedEventArgs e)
        {
            addNum("5");
        }
        private void button6_Click(object sender, RoutedEventArgs e)
        {
            addNum("6");
        }
        private void button7_Click(object sender, RoutedEventArgs e)
        {
            addNum("7");
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            addNum("8");
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            addNum("9");
        }

        

        private void button_Equal_Click(object sender, RoutedEventArgs e)
        {
            
            Oblicz();
            resultTextBox.Text = liczba1;
            typOperacji = 0;

        }


        private void Oblicz()
        {

            double wynik = 0.0;

            if (liczba1.Length == 0)
                liczba1 = resultTextBox.Text;
            if (liczba2.Length == 0)
                liczba2 = resultTextBox.Text;



            switch (typOperacji)
            {
                case 1:
                    wynik = Double.Parse(liczba1) + Double.Parse(liczba2);
                    
                    break;
             
                case 2:
                    wynik = Double.Parse(liczba1) - Double.Parse(liczba2);
                    
                    
                    break;
                case 3:
                    wynik = Double.Parse(liczba1) * Double.Parse(liczba2);
                    
                    break;
                case 4:

                    if (Double.Parse(liczba2) != 0.0)
                    {
                        wynik = Double.Parse(liczba1) / Double.Parse(liczba2);

                    }
                    else { 
                        MessageBox.Show($"elError");
                    

            }
                    break;

             

                default:
                    wynik = Double.Parse(liczba1) + Double.Parse(liczba2);
                    break;

                

            }

            liczba1 = wynik.ToString();
            liczba2 = "";
            erasedField = false;
        }


    }

  


}


