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

namespace variaviesAula01
{
   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //Declaraão das variaveis
        double N1, N2, Resultado;
        private void btnsomar_Click(object sender, RoutedEventArgs e)
        {
            //Entrada de dados
            N1 = Convert.ToDouble(txtNumero1.Text); //efetuando a conversão de string para double
            N2 = Convert.ToDouble(txtNumero2.Text);

            //Efetuando o cálculo
            Resultado = N1 + N2;

            //Saída de dados
            lblResultado.Content = "Somar: " + Resultado.ToString();
        }

        private void btnSubtrair_Click(object sender, RoutedEventArgs e)
        {
           

            //Entrada de dados
            N1 = Convert.ToDouble(txtNumero1.Text); //efetuando a conversão de string para double
            N2 = Convert.ToDouble(txtNumero2.Text);

            //Efetuando o cálculo
            Resultado = N1 - N2;

            //Saída de dados
            lblResultado.Content = "Subtrair: " + Resultado.ToString();
        }

        private void btnDividir_Click(object sender, RoutedEventArgs e)
        {
            
            //Entrada de dados
            N1 = Convert.ToDouble(txtNumero1.Text); //efetuando a conversão de string para double
            N2 = Convert.ToDouble(txtNumero2.Text);

            //Efetuando o cálculo
            Resultado = N1 / N2;

            //Saída de dados
            lblResultado.Content = "Dividir: " + Resultado.ToString();
        }

        private void btnMultiplicar_Click(object sender, RoutedEventArgs e)
        {
            
            //Entrada de dados
            N1 = Convert.ToDouble(txtNumero1.Text); //efetuando a conversão de string para double
            N2 = Convert.ToDouble(txtNumero2.Text);

            //Efetuando o cálculo
            Resultado = N1 * N2;

            //Saída de dados
            lblResultado.Content = "Multiplicar: " + Resultado.ToString();
        }
    }
}
