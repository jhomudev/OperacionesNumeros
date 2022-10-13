using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace OperacionesNumeros
{
    public partial class MainPage : ContentPage
    {
        int num1, num2;
        double resul;
        double n1,n2;
        string message;
       
        public MainPage()
        {
            InitializeComponent();
        }
        
        private void btnSumar_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txFirstNum.Text) || string.IsNullOrEmpty(txSecondtNum.Text))
            {
                DisplayAlert("Campos vacios", "Por favor. Ingrese los dos números", "OK");
            }
            else
            {
                num1 = Convert.ToInt32(txFirstNum.Text);
                num2 = Convert.ToInt32(txSecondtNum.Text);
                n1 = Convert.ToDouble(num1);
                n2 = Convert.ToDouble(num2);
                resul = n1 + n2;
                message = $"La suma de {n1} y {n2} es igual a {resul}";
                DisplayAlert("Suma de números", message, "OK");
            }
        }

        private void btnRestar_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txFirstNum.Text) || string.IsNullOrEmpty(txSecondtNum.Text))
            {
                DisplayAlert("Campos vacios", "Por favor. Ingrese los dos números", "OK");
            }
            else
            {
                num1 = Convert.ToInt32(txFirstNum.Text);
                num2 = Convert.ToInt32(txSecondtNum.Text);
                n1 = Convert.ToDouble(num1);
                n2 = Convert.ToDouble(num2);
                resul = n1 - n2;
                message = $"La resta de {n1} y {n2} es igual a {resul}";
                DisplayAlert("Resta de números", message, "OK");
            }
        }

        private void btnMulti_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txFirstNum.Text) || string.IsNullOrEmpty(txSecondtNum.Text))
            {
                DisplayAlert("Campos vacios", "Por favor. Ingrese los dos números", "OK");
            }
            else
            {
                num1 = Convert.ToInt32(txFirstNum.Text);
                num2 = Convert.ToInt32(txSecondtNum.Text);
                n1 = Convert.ToDouble(num1);
                n2 = Convert.ToDouble(num2);
                resul = n1 * n2;
                message = $"La multiplicación de {n1} y {n2} es igual a {resul}";
                DisplayAlert("Multiplicación de números", message, "OK");
            }
            
        }

        private void btnDivi_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txFirstNum.Text) || string.IsNullOrEmpty(txSecondtNum.Text))
            {
                DisplayAlert("Campos vacios", "Por favor. Ingrese los dos números", "OK");
            }
            else
            {
                num1 = Convert.ToInt32(txFirstNum.Text);
                num2 = Convert.ToInt32(txSecondtNum.Text);
                n1 = Convert.ToDouble(num1);
                n2 = Convert.ToDouble(num2);
                resul = n1 / n2;
                message = $"La división de {n1} y {n2} es igual a {resul}";
                DisplayAlert("División de números", message, "OK");
            }
            
        }
    }
}
