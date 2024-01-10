using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Practica3_JSVE;

namespace Practica3_JSVE
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void btnCriticar(object sender, EventArgs e)
        {
            var nombre = Entry1.Text;
            string mensage = nombre + " es:";

            if(Hombre.IsChecked == true) 
            {
                if (Alto.IsChecked == true)
                {
                    mensage += " alto";
                }
                if (Feo.IsChecked == true)
                {
                    mensage += " feito";
                }
                if (Listo.IsChecked == true)
                {
                    mensage += " listo";
                }
                if(Extrav.IsChecked == true)
                {
                    mensage += " extravagante";
                }
                if(Raro.IsChecked == true)
                {
                    mensage += " rarito";
                }

                if(Grande.IsChecked == true)
                {
                    mensage += " grande";
                }

            }
       else if(Mujer.IsChecked == true)
            {
                if (Alto.IsChecked == true)
                {
                    mensage += " altita";
                }
                if (Feo.IsChecked == true)
                {
                    mensage += " feita";
                }
                if (Listo.IsChecked == true)
                {
                    mensage += " lista";
                }
                if (Extrav.IsChecked == true)
                {
                    mensage += " extravagante";
                }
                if (Raro.IsChecked == true)
                {
                    mensage += " rarita";
                }

                if (Grande.IsChecked == true)
                {
                    mensage += " grandecita";
                }
            }
            Resultado.Text = mensage;
        }

    }
}







//Lo que quiero hacer que en el primer Entry que dice escribe, en el radiobutton  x:Name="Hombre" y  x:Name="Mujer", y en los checkbox que hay ALTO, FEO, LISTO, EXTRAVAGANTE, RARO, GRANDE, al momento de seleccionar una o poner un nombre te salga algo asi: Jose es ALTO, RARO Y 