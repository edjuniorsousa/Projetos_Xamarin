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
	public partial class CalculadoraSimples : ContentPage
	{
		public CalculadoraSimples ()
		{
			InitializeComponent ();
		}

        private void Executar_Clicked(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            Double a = 0, b = 0, t = 0;
            a = Convert.ToDouble(etValorA.Text);
            b = Convert.ToDouble(etValorB.Text);
            if (bt.Text == "+")
                t = a + b;
            if (bt.Text == "-")
                t = a - b;
            if (bt.Text == "/")
                t = a / b;
            if (bt.Text == "*")
                t = a * b;

            lbResp.Text = t.ToString();

        }

    }
}