using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsM1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ParOuImpar : ContentPage
	{
		public ParOuImpar ()
		{
			InitializeComponent ();
            btExecutar.Clicked += BtExecutar_Clicked;
		}

        private void BtExecutar_Clicked(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(etValor.Text);
            string resultado = "";
            if (numero % 2 == 0)
                resultado = "O número " + etValor.Text + " é par";
            else
                resultado = "O número " + etValor.Text + " é ímpar";

            lbResposta.Text = resultado;
        }
    }
}