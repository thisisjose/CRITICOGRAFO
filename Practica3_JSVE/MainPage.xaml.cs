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
            var mensaje = new StringBuilder($"{nombre} es");

            if (Hombre.IsChecked == true || Mujer.IsChecked == true)
            {
                if (Hombre.IsChecked == true)
                {
                    BtnComa(mensaje, Alto, "alto");
                    BtnComa(mensaje, Feo, "feo");
                    BtnComa(mensaje, Listo, "listo");
                    BtnComa(mensaje, Extrav, "extravagante");
                    BtnComa(mensaje, Raro, "raro");
                    BtnComa(mensaje, Grande, "grande");
                }
                else
                {
                    BtnComa(mensaje, Alto, "altita");
                    BtnComa(mensaje, Feo, "feita");
                    BtnComa(mensaje, Listo, "lista");
                    BtnComa(mensaje, Extrav, "extravagante");
                    BtnComa(mensaje, Raro, "rarita");
                    BtnComa(mensaje, Grande, "grandecita");
                }
            }

            string mensajeString = mensaje.ToString().TrimEnd(' ', ',');

            string[] partes = mensajeString.Split(new string[] { ", " }, StringSplitOptions.None);
            if (partes.Length > 1)
            {
                mensaje = new StringBuilder(string.Join(", ", partes.Take(partes.Length - 1)) + " y " + partes.Last());
            }

            Resultado.Text = mensaje.ToString() + ".";
        }

        private void BtnComa(StringBuilder mensaje, CheckBox checkBox, string caracteristica)
        {
            if (checkBox.IsChecked == true)
            {
                if (mensaje.Length > 0)
                {
                    mensaje.Append(", ");
                }

                mensaje.Append(caracteristica);
            }
        }
    }
}
